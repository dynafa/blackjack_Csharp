using System.Drawing;

namespace GameSetup
{
    /* This class handles all aspects of the game which are to do with calculating and controlling to different stages
     of gameplay with would not suit being in the main form */
    class Dealer
    {
        private bool twocardhand;
        private int cardcounter = 2;
        private int housecardcounter = 2;
        private string handsum = "";
        private int hittracker = 0;
        private int househittracker = 0;
        private Deck gamedeck;
        private Graphics canvas;
        private Hand playersHand;
        private Hand dealersHand;
        private Chipstack playerschips;
        private Chipstack currentbet;
        private int playerxCoord = 550;
        private int playeryCoord = 200;
        private int dealerxCoord = 1000;
        private int dealeryCoord = 200;
        private int hitxCoord = 580;
        private int hityCoord = 230;
        private int househitxCoord = 1030;
        private int househityCoord = 230;
        private string chipcolor;
        private int chipquantity;
        private int chipvalue;
        private int chipgoal;


        public Dealer(Graphics canvas)
        {
            this.canvas = canvas;
            gamedeck = new Deck(canvas, 52);
        }

        public int placeBet(int minbet, int bettracker)
        {
            int betvalue = bettracker + 1;
            return minbet * betvalue;
        }

        public void houseHit()
        {
            bool houseControl = true;
            while (houseControl == true)
            {
                int housesum = dealersHand.handSum();
                if (housesum < 17)
                {
                    Card housecard = gamedeck.top();
                    dealersHand.addCard(housecard, housecardcounter);
                    dealersHand.showcard(housecardcounter++).show(househitxCoord + 30, househityCoord + 30);
                    househitxCoord = househitxCoord + 30;
                    househityCoord = househityCoord + 30;
                }
                else
                {
                    houseControl = false;
                }
            }

        }
        public void startHit()
        {
            twocardhand = false;
            hittracker = 0;
            hitCard(hittracker);
            handsum = playersHand.handSum().ToString();
        }
        private void hitCard(int hittracker)
        {
            Card thiscard = gamedeck.top();
            playersHand.addCard(thiscard, cardcounter);
            hitxCoord = hitxCoord + 30;
            hityCoord = hityCoord + 30;
            playersHand.showcard(cardcounter++).show(hitxCoord, hityCoord);
            hittracker++;
        }

        public void startDeal()
        {
            twocardhand = true;
            Card card1 = gamedeck.top();
            Card card2 = gamedeck.top();
            Card card3 = gamedeck.top();
            Card card4 = gamedeck.top();
            playersHand = new Hand(canvas, card1);
            dealersHand = new Hand(canvas, card2);
            playersHand.addCard(card3, 1);
            dealersHand.addCard(card4, 1);
            playersHand.showcard(0).show(playerxCoord, playeryCoord);
            dealersHand.showcard(0).show(dealerxCoord, dealeryCoord);
            card2.showCardback();
            playersHand.showcard(1).show(playerxCoord + 30, playeryCoord + 30);
            handsum = playersHand.handSum().ToString();
        }
        public void dealHousecards()
        {
            dealersHand.showcard(1).show(dealerxCoord + 30, dealeryCoord + 30);
        }

        public string showSum()
        {
            return playersHand.handSum().ToString();
        }
        public string showHousesum()
        {
            return dealersHand.handSum().ToString();
        }
        public bool checkScore(int currentscore)
        {
            int playerschipgoal = playerschips.getChipgoal();
            bool wonGame = currentscore >= playerschipgoal;
            switch (wonGame)
            {
                case true:
                    return true;
                case false:
                    return false;
                default:
                    return false;
            }
        }

        public void chipstackSetup(string level)
        {
            switch (level)
            {
                case "PLATINUM":
                    chipcolor = "purple";
                    chipgoal = 25000;
                    chipquantity = 10000;
                    chipvalue = 100;
                    break;
                case "GOLD":
                    chipcolor = "black";
                    chipgoal = 12500;
                    chipquantity = 5000;
                    chipvalue = 100;
                    break;
                case "SILVER":
                    chipcolor = "green";
                    chipgoal = 5000;
                    chipquantity = 2000;
                    chipvalue = 100;
                    break;
                case "BRONZE":
                    chipcolor = "white";
                    chipgoal = 2500;
                    chipquantity = 1000;
                    chipvalue = 100;
                    break;
            }
            playerschips = new Chipstack(canvas, chipcolor, chipquantity, chipvalue, chipgoal);
        }
        public int showPlayerschips()
        {
            return playerschips.showStackvalue();
        }
        public string showChipcolor()
        {
            return playerschips.getChipcolor();
        }
        public void resetHittracker()
        {
            checkDeck();
            hittracker = 0;
            househittracker = 0;
            hitxCoord = 580;
            hityCoord = 230;
            househitxCoord = 1030;
            househityCoord = 230;
    }

        public string resolveWinnings()
        {
            int housesum = dealersHand.handSum();
            int playersum = playersHand.handSum();
            bool equalhands = playersum == housesum;
            bool housebust = housesum > 21;
            bool playerBJ = evalHand(playersum) == "BLACKJACK!";
            if (housebust) { return "win"; }
            if (!housebust)
            {
                if (equalhands & playerBJ) { return "win"; }
                if (equalhands) { return "push"; }
                if (housesum < playersum) { return "win"; }
                else return "lose";
            }
            else return "win";
        }
        public string evalHand(int intsum)
        {
            if (twocardhand == false & intsum == 21)
            {
                return "TWENTY ONE!";
            }
            if (twocardhand == true & intsum == 21)
            {
                return "BLACKJACK!";
            }
            if (intsum > 21)
            {
                return "YOU BUST!";
            }
            if (intsum < 21)
            {
                return "HIT AGAIN?";
            }
            else
            {
                return "HIT?";
            }
        }
        public void drawBlackjack()
        {
            int dealerxCoord = 500;
            int dealeryCoord = -170;
            string imagesrc = "blackjack";
            canvas.DrawImage((Image)Properties.Resources.ResourceManager.GetObject(imagesrc), dealerxCoord + 30, dealeryCoord + 30, 750, 1000);
        }
        public void checkDeck()
        {
            int deckCards = gamedeck.showIndex();
            if (deckCards < 10)
            {
               gamedeck = new Deck(canvas, 52);
            }
        }
        public int checkGoal()
        {
            return playerschips.getChipgoal();
        }
        public int printDeckindex()
        {
            int deckCards = gamedeck.showIndex();
            return deckCards;
        }
    }
}
