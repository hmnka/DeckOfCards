namespace DeckOfCards
{
    class Card
    {

        #region "Properties"

        private readonly CardSuit cSuit;
        private readonly CardNumber cNumber;

        public CardSuit Suit
        {
            get { return cSuit; }
        }

        public CardNumber Number
        {
            get { return cNumber; }
        }

        #endregion "Properties"

        #region "Constructor"
        /// <summary>
        /// Card Constructor. Sets the suit and number of Card
        /// </summary>
        /// <param name="suit">The Suit of the Card (0-3)</param>
        /// <param name="number">The Number of the Card (1-13)</param>
        public Card(int suit, int number)
        {
            cSuit = (CardSuit)suit;
            cNumber = (CardNumber)number;
        }
        #endregion "Constructor"

        #region "Enums"
        //Card Suits
        public enum CardSuit
        {
            Clubs = 0,
            Diamonds = 1,
            Hearts = 2,
            Spades = 3,
        }

        //Card Numbers
        public enum CardNumber
        {
            Two = 1,
            Three = 2,
            Four = 3,
            Five = 4,
            Six = 5,
            Seven = 6,
            Eight = 7,
            Nine = 8,
            Ten = 9,
            Jack = 10,
            Queen = 11,
            King = 12,
            Ace = 13,
        }
        #endregion "Enums"
    }
}
