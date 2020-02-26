using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        #region "Properties"
        public List<Card> MyDeck;
        #endregion "Properties"

        #region "Methods"
        /// <summary>
        /// Contructor. Create a List of Cards and Initialize.
        /// </summary>
        public Deck()
        {
            MyDeck = new List<Card>();

            Initialize();
        }

        /// <summary>
        /// Set the deck. Initializes the Deck with 52 Cards and shuffles it.
        /// </summary>
        public void Initialize()
        {
            MyDeck.Clear();

            for (int i = 0; i < 4; i++)         //Suit values 0-3 (0-Clubs, 1-Diamonds, 2-Hearts, 3-Spades)
            {
                for (int j = 1; j < 14; j++)    //Card Numbers 1-13 (Numbers ordered from 2 to 10, Jack, Queen, King, Ace)
                {
                    MyDeck.Add(new Card(i, j));
                }
            }

            shuffle();
        }

        /// <summary>
        /// Shuffle the deck.
        /// </summary>
        public void shuffle()
        {
            Random rnd = new Random();
            for (int i = 0; i < MyDeck.Count; i++)
            {
                //FisherYates shuffle
                var temp = MyDeck[i];
                var index = rnd.Next(0, MyDeck.Count);
                MyDeck[i] = MyDeck[index];
                MyDeck[index] = temp;
            }
        }


        /// <summary>
        /// Play a card from top of the Deck. Null if Deck is empty.
        /// </summary>
        /// <returns>Card</returns>
        public Card playCard()
        {
            Card myCard;
            if (MyDeck.Count == 0)
            {
                return null;
            }
            int index = MyDeck.Count - 1;
            myCard = MyDeck[index];
            MyDeck.RemoveAt(index);
            return myCard;
        }

        /// <summary>
        /// Gets the number of cards present on the Deck
        /// </summary>
        /// <returns>Int - Current count of Deck</returns>
        public int getCurrentCardCount()
        {
            return MyDeck.Count;
        }
        #endregion "Methods"
    }
}
