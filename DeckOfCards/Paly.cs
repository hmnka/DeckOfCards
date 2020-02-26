using System;

namespace DeckOfCards
{
    class Paly
    {
        static void Main(string[] args)
        {
            //Create Facade Object
            Facade facade = new Facade();
            //Create the Deck
            Deck deck = new Deck();

            UserChoice choice = UserChoice.Unassigned;

            Console.WriteLine("-----A Deck of Cards-----");
            while (choice != UserChoice.Exit)
            {
                Console.WriteLine("\n>Enter 1 to Play a card. \n>Enter 2 to Shuffle the Deck. \n>Enter 3 to Reset the Deck. \n>Enter 4 to exit.");

                //Take User Input
                string input = Console.ReadLine();
                Enum.TryParse(input, out choice);

                if (choice == UserChoice.PlayCard)
                {
                    facade.UserPlaysCard(deck);
                }
                else if (choice == UserChoice.Shuffle)
                {
                    facade.UserShufflesDeck(deck);
                }
                else if (choice == UserChoice.ResetDeck)
                {
                    facade.UserResetsDeck(deck);
                }
                else
                {
                    Console.WriteLine("\nEnter a valid option");
                }
            }
        }

        //User Choices
        public enum UserChoice
        {
            PlayCard = 1,
            Shuffle = 2,
            ResetDeck = 3,
            Exit = 4,
            Unassigned = -1
        }
    }
}
