using System.Drawing;

namespace GameSetup
{
    /* This class is more or less the "canvas manager", it's purpose is to help the dealer class handle different variables and events in the game.
     It is one of the main 3 classes which handles game play, along with dealer and Mainform.
         */
    class Game
    {
        private string playerName;
        private string gamelevel;
        private Graphics canvas;
        private int chipmin;
        private int decksize;

        public Game(Graphics canvas, string gamelevel, string playerName,int chipmin)
        {// Here is the constructor for the Game class. "chipmin" is the minumum bet which a player can put down onto the table.
            this.playerName = playerName;
            this.gamelevel = gamelevel;
            this.canvas = canvas;
            this.chipmin = chipmin;
        }
        // Basic getter for calculating how many chips the canvas should draw based on the current game level.
        public int getChipmin()
        {
            return chipmin;
        }

        public void drawCardplaceholders()
        {/* This method is responsible for drawing the areas to define where the player should expect to see the cards 
         appear on the screen */
            // Create pen.
            SolidBrush blueBrush = new SolidBrush(Color.PeachPuff);
            // Create location and size of rectangle.
            int x = 520;
            int y = 160;
            int width = 350;
            int height = 500;

            // Draw rectangle to screen.
            canvas.FillRectangle(blueBrush, x, y, width, height);
            canvas.FillRectangle(blueBrush, x + 450, y, width, height);
            // Create pen.
            Pen blackPen = new Pen(Color.Gold, 6);

            // Draw rectangle to screen.
            canvas.DrawRectangle(blackPen, x, y, width, height);
            canvas.DrawRectangle(blackPen, x + 450, y, width, height);
        }
        public void coverCurrentbet()
        {/* This method is responsible for covering the area where the players chips are laid in order to be able to
            redraw those chips when the player decides to change the amount of their wager */
            SolidBrush blueBrush = new SolidBrush(Color.DarkGreen);

            // Create location and size of rectangle
            int x = 420;
            int y = 680;
            int width = 600;
            int height = 120;

            // Fill rectangle to screen
            canvas.FillRectangle(blueBrush, x, y, width, height);
        }

        public void drawOutcome(string imagesrc)
        {// This method displays a graphic which indicates what the outcome of the hand is to the player, e.g. win, lose, push, blackjack;
            // Basic coordinates and dimensions
            int xCoord = 600;
            int yCoord = -100;
            int xDim = 675;
            int yDim = 900;
            canvas.DrawImage((Image)Properties.Resources.ResourceManager.GetObject(imagesrc), xCoord, yCoord, xDim, yDim);
        }
    }
}
