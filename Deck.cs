using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace GameSetup
{

    /* The deck class basically consists of a few arrays, ordered and unordered. 
    In order to be efficient with how the strings for each card are coded, I have used a for loop to automatically
    generate them, after doing such I have made a list which I have shuffled, and then used the unordered ints to 
    create disorder with the second deck.*/
    class Deck
    {
        private int cardIndex;
        private Card[] orderedcards = new Card[52];
        private Card[] unorderedcards = new Card[52];
        private int numbervalue = 0;

        public Deck(Graphics canvas, int size)
        {
            int index = 0;
            while (index < size)
            {
                for (int rank = 1; rank <= 13; rank++)
                {
                    foreach (string suit in new string[] { "hearts", "clubs", "spades", "diamonds" })
                    {
                        numbervalue = rank;
                        if (rank == 1) { numbervalue = 11; }
                        if (rank > 10) { numbervalue = 10; }
                        orderedcards[index++] = new Card(canvas, suit, rank, numbervalue);
                    }
                }
            }
            cardIndex = orderedcards.Length - 1;
            Random rnd;
            int card;
            List<int> ShuffledDeck;
            rnd = new Random();
            ShuffledDeck = new List<int>(size);
            
            List<int> DeckSequence = Enumerable.Range(0, size).ToList();

            for (int i = 0; i < size; i++)
            {
                card = DeckSequence[rnd.Next(0, DeckSequence.Count)];
                DeckSequence.Remove(card);
                ShuffledDeck.Add(card);
            }
            int localindex = 51;
            foreach (int cards in ShuffledDeck)
            {
                int rank;
                string suit;
                Card newcard = orderedcards[localindex--];
                suit = newcard.getSuit();
                rank = newcard.getRank();
                numbervalue = newcard.getCardvalue();
                unorderedcards[cards] = new Card(canvas, suit, rank, numbervalue);
            }
        }
        // Returns a card from the top of the deck
        public Card top()
        {
            return unorderedcards[cardIndex--];
        }
        // Shows current index of top card, here I used it to determine whether the deck still has enough cards to 
        // continue the game play without hitting a null ref.
        public int showIndex()
        {
            return cardIndex;
        }
    }
}