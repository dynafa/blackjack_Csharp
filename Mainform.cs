using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameSetup
{
    public partial class Mainform : Form
    {
        //This class is where most of the Player-GUI interaction takes place.
        // Main objects of the game
        private Graphics canvas;
        private Dealer house;
        private Game currentgame;

        //Timers which control certain events in the game
        private Timer myTimer = new Timer();
        private Timer mainbgTimer = new Timer();
        private Timer restartTimer = new Timer();

        // Other variables used within this class
        private Color chipcolor;
        private int chipmin;
        private int bettracker;
        private bool playerbust = false;
        private int chipcalc = 0;
        private int wager = 0;
        private string gameLevel;
        private bool doubleDownHand = false;
        private bool playerHasbet = false;
        private bool wongame = false;

        public Mainform()
        {
            InitializeComponent();
        }
        private void cardTablePicturebox_Click(object sender, EventArgs e)
        { }

        // On form load, canvas and house are created. This sets a timer going which will draw the main  background image on the home screen.
        private void Form1_Load(object sender, EventArgs e)
        {
            canvas = cardTablePicturebox.CreateGraphics();
            house = new Dealer(canvas);
            mainbgTimer.Interval = 30;
            mainbgTimer.Tick += new EventHandler(drawMonkey);
            mainbgTimer.Enabled = true;
            mainbgTimer.Start();

        }
        // Private method of drawing main background.
        private void drawMonkey(Object s, EventArgs e)
        {
            house.drawBlackjack();
            mainbgTimer.Stop();
            mainbgTimer.Enabled = false;
        }

        //Show highscores
        private void highscoreBtn_Click(object sender, EventArgs e)
        {
            highscores newwin = new highscores();
            newwin.Show();
        }

        //Main button used by the user to hit a card while in active gameplay, if the player's hand goes bust, the hand finishes immediately
        public void hitBtn_Click(object sender, EventArgs e)
        {
            house.startHit();
            middlelabelbox.Text = house.showSum();
            int intsum = int.Parse(house.showSum());
            dealertest.Text = house.evalHand(intsum);
            if (dealertest.Text == "YOU BUST!")
            {
                playerbust = true;
                findWinner_Click(sender, e);
            }
        }
        // This clears up any timers or graphics which are not needed on the canvas
        private void finishHand(object sender, EventArgs e)
        {
            canvas.Clear(Color.DarkGreen);
            house.resetHittracker();
            house.checkDeck();
            deckstate.Text = house.printDeckindex().ToString();
            currentgame.drawCardplaceholders();
            chipDrawover(sender, e);
            middlelabelbox.Text = "";
            dealerHandsum.Text = "";
            restartTimer.Stop();
            restartTimer.Enabled = false;
            newGame.Enabled = true;
        }

        //Double down option for player if their hand is less than 21
        private void doubleBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(house.showSum()) < 11)
            {
                house.startHit();
                doubleDownHand = true;
                findWinner_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sorry, your hand is greater than 11, so you can't double down!");
            }
        }
        // At this point in the game, the player decides their hand is good enough to win
        // The dealer will then deal themselves cards
        private void standBtn_Click(object sender, EventArgs e)
        {
            house.dealHousecards();
            dealerHandsum.Text = house.showHousesum();
            house.houseHit();
            toggleButtonstates();
            findWinner_Click(sender, e);
            
        }
        // Main button to start playing a new hand once they have selected the game level and entered their name
        private void newGame_Click(object sender, EventArgs e)
        {
            if (playerHasbet != true)
            {
                MessageBox.Show("Please make a bet first!");
            }
            else
            {
                currentgame.drawCardplaceholders();
                house.startDeal();
                middlelabelbox.Text = house.showSum();
                int intsum = int.Parse(house.showSum());
                dealertest.Text = house.evalHand(intsum);
                deckstate.Text = house.printDeckindex().ToString();
                abortGame.Enabled = true;
                middlelabelbox.Visible = true;
                dealerHandsum.Visible = true;
                toggleButtonstates();
            }
        }
        // This toggles the state of the buttons so that they are not accessible during certain parts of game play
        private void toggleButtonstates()
        {
            newGame.Enabled = !newGame.Enabled;
            raiseBetamount.Enabled = !raiseBetamount.Enabled;
            lowerBetamount.Enabled = !lowerBetamount.Enabled;
            hitBtn.Enabled = !hitBtn.Enabled;
            doubleBtn.Enabled = !doubleBtn.Enabled;
            surrenderBtn.Enabled = !surrenderBtn.Enabled;
            standBtn.Enabled = !standBtn.Enabled;
        }        


        private void playerNamelabel_Click(object sender, EventArgs e)
        { }

        private void playernameTextbox_TextChanged(object sender, EventArgs e)
        {
            middlelabelbox.Text = "Welcome to BlackJack Master " + playernameTextbox.Text + "!"; 
        }

        private void gameLevellabel_Click(object sender, EventArgs e)
        {

        }
        
        // This determines certain variables of the game based on the difficulty chosen
        private void gameLevelChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = gameLevelChoice.SelectedIndex;
            string playername = playernameTextbox.Text;
            switch (choice)
            {
                case 0:
                    chipcolor = Color.WhiteSmoke;
                    gameLevel = "PLATINUM";
                    chipmin = 500;
                    break;
                case 1:
                    chipcolor = Color.Gold;
                    gameLevel = "GOLD";
                    chipmin = 300;
                    break;
                case 2:
                    chipcolor = Color.Silver;
                    gameLevel = "SILVER";
                    chipmin = 200;
                    break;
                case 3:
                    chipcolor = Color.RosyBrown;
                    gameLevel = "BRONZE";
                    chipmin = 100;
                    break;
            }
            // This sets up those variables based the outcome of the players choice and also creates a game object
            // from those variables
            house.chipstackSetup(gameLevel);
            chipContainer.Text = house.showPlayerschips().ToString();
            startGame.BackColor = chipcolor;
            gameLevelChoice.BackColor = chipcolor;
            playernameTextbox.BackColor = chipcolor;
            playerNamelabel.BackColor = chipcolor;
            gameLevellabel.BackColor = chipcolor;
            sidePanel.BackColor = chipcolor;
            house.chipstackSetup(gameLevel);
            chipContainer.Text = house.showPlayerschips().ToString();
            currentgame = new Game(canvas, gameLevel, playername, chipmin);
        }

        // This ensures the player has entered their name before they can initialise any game play
        private void startGame_Click(object sender, EventArgs e)
        {
            if(playernameTextbox.Text == "")
            {
                MessageBox.Show("Please enter your name!");
            }
            else
            {
                // This will hide many buttons so they are not in the way when the game starts
                myTimer.Interval = 30;
                myTimer.Tick += new EventHandler(onTimerElapsed);
                gameLevelChoice.Hide();
                gameLevellabel.Hide();
                playerNamelabel.Hide();
                playernameTextbox.Hide();
                startGame.Hide();
                sidePanel.Hide();
                highscoreBtn.Hide();
                raiseBetamount.Enabled = true;
                lowerBetamount.Enabled = true;
                newGame.Enabled = true;
                myTimer.Enabled = true;
                myTimer.Start();
            }
        }

        private void chipTotallabel_Click(object sender, EventArgs e)
        {

        }
        // I have used timers here so that the canvas has the right graphics displayed at the appropriate times
        private void onTimerElapsed(Object s, EventArgs e)
        {
            canvas.Clear(Color.DarkGreen);
            currentgame.drawCardplaceholders();
            myTimer.Stop();
            myTimer.Enabled = false;            
        }

        private void middlelabelbox_Click(object sender, EventArgs e)
        {

        }

        private void dealertest_Click(object sender, EventArgs e)
        {

        }

        private void betContainer_Click(object sender, EventArgs e)
        {

        }
        // This allows the player to lower their bet, however not if they have not yet raised any bet!
        private void lowerBetamount_Click(object sender, EventArgs e)
        {
            if (playerHasbet != true)
            {
                MessageBox.Show("You have not even bet yet!");
            }
            else
            {
                betButtonclick(0);
            }
        }
        // Player can raise a bet, once doing so they can then lower that bet.
        private void raiseBetamount_Click(object sender, EventArgs e)
        {
            playerHasbet = true;
            betButtonclick(1);
        }
        // This redraws the chips once they are covered over during the transition between hands.
        private void chipDrawover(object sender, EventArgs e)
        {
            betButtonclick(2);
        }

        // THis where the effects of clicking on the raise and lower bet buttons are coded for efficiency
        private void betButtonclick(int inputindex)
        {
            int xPos = 420;
            int yPos = 680;
            int width = 100;
            int height = 100;
            int minbet = currentgame.getChipmin();
            switch (inputindex)
            {
                case 0:
                    // because the lower bet changes the wager in a different way, therefore i
                    // have split those different outcomes with a switch and case technique
                    wager = int.Parse(betContainer.Text) - minbet;
                    bettracker--;
                    break;
                case 1:
                    wager = house.placeBet(minbet, bettracker++);
                    break;
                case 2:
                    wager = house.placeBet(minbet, bettracker);
                    break;
            }
            // Outcome is determined based on button clicks
            chipcalc = wager / minbet;
            currentgame.coverCurrentbet();
            for (int index = 0; index < chipcalc; index++)
            {
                xPos = xPos + 30;
                canvas.DrawImage((Image)Properties.Resources.ResourceManager.GetObject(house.showChipcolor()), xPos, yPos, width, height);
            }
            betContainer.Text = wager.ToString();

        }
        // This is where the game determines the outcome from the players decisions
        // The mainform calls methods from the Dealer call in order to properly determine what is going on
        private void findWinner_Click(object sender, EventArgs e)
        {
            newGame.Enabled = false;
            int intsum = int.Parse(house.showSum());
            dealerHandsum.Text = house.showHousesum();
            int newTotal = 0;
            int myChips = int.Parse(chipContainer.Text);
            int bet = int.Parse(betContainer.Text);
            string outcome = house.resolveWinnings();
            // if the player busts, the game resolves to a loss immediately
            if (playerbust == true)
            {
                outcome = "lose";
            }
            playerbust = false;
            // Here i am differentiating between a 21 and blackjack
            if (house.evalHand(intsum) == "BLACKJACK!" && outcome == "win")
            {
                dealertest.Text = "WINNER BJ!";
                newTotal = (bet * 4) + myChips;
                currentgame.drawOutcome("blackjack");
            }
            // Here, a normal win and double down are handled together
            if (house.evalHand(intsum) != "BLACKJACK!" && outcome == "win")
            {
                if (doubleDownHand)
                {
                    newTotal = (bet * 2) + myChips;
                }
                else
                {
                    newTotal = bet + myChips;
                }
                dealertest.Text = "WINNER!";
                currentgame.drawOutcome("winner");
            }
            if (outcome == "lose")
            {
                dealertest.Text = "YOU LOSE!";
                newTotal = myChips - bet;
                currentgame.drawOutcome("loser");
            }
            if (outcome == "push")
            {
                dealertest.Text = "PUSH!";
                currentgame.drawOutcome("push");
            }
            chipContainer.Text = newTotal.ToString();
            raiseBetamount.Enabled = true;
            lowerBetamount.Enabled = true;
            restartTimer.Interval = 1800;
            restartTimer.Enabled = true;
            restartTimer.Tick += new EventHandler(finishHand);
            restartTimer.Start();
            checkforWin(sender, e);
        }
        // Here the game is looking to see if they player has won enough chips to win the game
        private void checkforWin(Object sender, EventArgs e)
        {
            int currentscore = int.Parse(chipContainer.Text);
            wongame = house.checkScore(currentscore);
            if (wongame)
            {
                playerwinsGame(sender, e);
            }
        }
        // If the player wants to stop the game, they can do so, however all the elements which are part of the
        // home screen must be replaced. ALl of that is done here in this method.
        private void stopGame(Object sender, EventArgs e)
        {
            toggleButtonstates();
            currentgame.coverCurrentbet();
            canvas.Clear(Color.DarkGreen);
            drawMonkey(sender, e);
            gameLevelChoice.Show();
            gameLevellabel.Show();
            playerNamelabel.Show();
            playernameTextbox.Show();
            startGame.Show();
            sidePanel.Show();
            highscoreBtn.Show();
            raiseBetamount.Enabled = false;
            lowerBetamount.Enabled = false;
            middlelabelbox.Visible = false;
            dealerHandsum.Visible = false;
            abortGame.Enabled = false;
            newGame.Enabled = false;
            betContainer.Text = "";
            chipContainer.Text = "";
            dealertest.Text = "";
        }

        private void playerwinsGame(Object s, EventArgs e)
        {

        }
        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deckstate_Click(object sender, EventArgs e)
        {
        }

        private void surrenderBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't give up! Believe in yourself!");
        }

        private void abortGame_Click(object sender, EventArgs e)
        {
            stopGame(sender, e);
        }
    }
}