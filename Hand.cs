using System.Drawing;

namespace GameSetup
{
    class Hand
    {
        private Card newcard;
        private Card[] cards = new Card[30];

        public Hand(Graphics canvas, Card newcard)
        {
            this.newcard = newcard;
            int rank = newcard.getRank();       
            string suit = newcard.getSuit();
            int numbervalue = newcard.getCardvalue();
            newcard = new Card(canvas, suit, rank, numbervalue);
            cards[0] = newcard;
        }
        public Card showcard(int i)
        {
            return cards[i];
        }

        public void addCard(Card newcard, int i)
        {
            cards[i] = newcard;
        }

        public int handSum()
         {

            int sum = 0;
            bool continueloop = true;
            while (continueloop == true)
                {
                for (int index = 0; index < cards.Length; index++)
                    {
                        try
                        {
                            int cardvalue = cards[index].getCardvalue();
                            sum = sum + cardvalue;
                        }
                        catch (System.NullReferenceException)
                        {
                            continueloop = false;
                        }
                    }
                }
            if (sum > 21)
            {
                continueloop = true;
                while (continueloop == true)
                {
                    for (int index = 0; index < cards.Length; index++)
                    {
                        try
                        {
                            int cardrank = cards[index].getRank();
                            if (cardrank == 1)
                            {
                                sum = sum - 10;
                            }
                        }
                        catch (System.NullReferenceException)
                        {
                            continueloop = false;
                        }

                    }
                }
            }
            return sum;
        }
        public int getCard()
        {
            return newcard.getCardvalue();
        }
    }
}
