using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Facade
    {

        /// <summary>
        /// Facade method to Draw a card
        /// </summary>
        /// <param name="deck">Deck</param>
        public void UserPlaysCard(Deck deck)
        {
            Card card = deck.playCard();
            if (card == null)
            {
                Console.WriteLine("\nDeck is empty. Please reset the Deck.");
            }
            else
            {
                Console.WriteLine("\n{0} of {1}", card.Number, card.Suit);
                Console.WriteLine("Current number of cards in Deck is {0}", deck.getCurrentCardCount());
            }
        }

        /// <summary>
        /// Facade method to Shuffle a Deck
        /// </summary>
        /// <param name="deck">Deck</param>
        public void UserShufflesDeck(Deck deck)
        {
            deck.shuffle();
            Console.WriteLine("\nDeck Shuffled!!");
        }

        /// <summary>
        /// Facade method to Reset Deck
        /// </summary>
        /// <param name="deck">Deck</param>
        public void UserResetsDeck(Deck deck)
        {
            deck.Initialize();
            Console.WriteLine("\nDeck Reset!!");
        }
    }
}
