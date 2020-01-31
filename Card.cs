using System.Drawing;

namespace GameSetup
{
    class Card
    {
        private Graphics canvas;
        private string suit;
        private int numbervalue;
        private int rank;
        private int xPos;
        private int yPos;
        private int width = 150;
        private int height =  210;

        public Card(Graphics canvas, string suit, int rank, int numbervalue)
        {
            this.canvas = canvas;
            this.suit = suit;
            this.rank = rank;
            this.numbervalue = numbervalue; 
            xPos = 100;
            yPos = 100;
        }

        public void show(int xPos, int yPos)
        {
            canvas.DrawImage((Image)Properties.Resources.ResourceManager.GetObject(suit + rank), xPos, yPos, width, height);
        }

        public void showCardback()
        {
            int dealerxCoord = 1000;
            int dealeryCoord = 200;
            string cardback = "cardback3";
            canvas.DrawImage((Image)Properties.Resources.ResourceManager.GetObject(cardback), dealerxCoord + 30, dealeryCoord + 30, width, height);
        }

        public int getRank()
        {
            return rank;
        }
        public string getSuit()
        {
            return suit;
        }
        public int getCardvalue()
        {
            return numbervalue;
        }


    }
}
