using System;
using System.Collections.Generic;

namespace BlackJack6
{
    class Program
    {
        static readonly Deck Deck = new Deck();
        private static readonly List<Card> PlayerCards = new List<Card>();
        private static readonly List<Card> DealerCards = new List<Card>();
        static int _chips = 100;
        static int _bet = 0;
        static int _round = 1;
        static State _state = State.Indecisive;

        static void Main(string[] args)
        {
            Display.PrintStartTitle();

            while (Deck.HasCards() && _chips > 0)
            {
                if (DealTwoCards())
                    return;

                while (true)
                {
                    if (DealAdditionalCardsToPlayer())
                        break;
                }

                if (_state != State.DealerWon)
                {
                    DealAdditionalCardsToDealer();
                }

                EstablishWinner();

                switch (_state)
                {
                    case State.PlayerWon:
                        Console.WriteLine($"You won with a hand value of: {CalculateCardValues(PlayerCards)}");
                        _chips += _bet;
                        break;
                    case State.DealerWon:
                        Console.WriteLine("You lost!");
                        _chips -= _bet;
                        break;
                }
                
                Console.WriteLine($"Chips left: {_chips}");
                Console.WriteLine("Press any to go to next round");
                Console.ReadKey(true);

                InitRound();
            }

            Console.WriteLine("GAME OVER");

            Console.ReadKey();
        }

        private static void EstablishWinner()
        {
            if (_state == State.Indecisive)
            {
                int dealerValue = CalculateCardValues(DealerCards);
                int playerValue = CalculateCardValues(PlayerCards);

                if (dealerValue == playerValue)
                {
                    if (PlayerCards.Count < 5)
                        _state = State.DealerWon;
                    else
                        _state = State.PlayerWon;
                }

                else if (dealerValue >= playerValue)
                {
                    _state = State.DealerWon;
                }
                else
                {
                    _state = State.PlayerWon;
                }
            }
        }

        private static void DealAdditionalCardsToDealer()
        {
            while (true)
            {
                if (CalculateCardValues(DealerCards) >= 17)
                {
                    break;
                }

                Console.Clear();
                Display.PrintHeader("Dealer");
                DealerCards.Add(DealCard());
                Console.WriteLine($"The total value of hand is {CalculateCardValues(DealerCards)}");

                if (CalculateCardValues(DealerCards) > 21)
                {
                    Console.WriteLine("BUSTED!");
                    _state = State.PlayerWon;
                    break;
                }
            }
        }

        private static bool DealAdditionalCardsToPlayer()
        {
            Display.PrintHeader("Enter (H)it or (S)tay");

            var choice = Console.ReadKey(true);

            while (choice.Key != ConsoleKey.H && choice.Key != ConsoleKey.S)
            {
                choice = Console.ReadKey(true);
            }

            if (choice.Key == ConsoleKey.S)
                return true;

            PlayerCards.Add(DealCard());

            Console.WriteLine($"The total value of hand is {CalculateCardValues(PlayerCards)}");

            if (CalculateCardValues(PlayerCards) > 21)
            {
                Console.WriteLine("BUSTED!");
                _state = State.DealerWon;
                Console.ReadKey(true);
                return true;
            }

            Console.WriteLine();
            return false;
        }

        private static bool DealTwoCards()
        {
            Console.WriteLine("Enter B(et) or Q(uit)");

            var key = Console.ReadKey(true);

            while (key.Key != ConsoleKey.B && key.Key != ConsoleKey.Q)
            {
                key = Console.ReadKey(true);
            }

            if (key.Key == ConsoleKey.Q)
                return true;

            _bet = GetBet();

            Console.Clear();

            Display.PrintHeader($"Round {_round}");
            Display.PrintHeader("Player");
            Console.WriteLine($"Chips left: {_chips}");

            PlayerCards.Add(DealCard());
            PlayerCards.Add(DealCard());

            Console.WriteLine();
            Console.WriteLine("The total value of hand is " + CalculateCardValues(PlayerCards));

            Display.PrintHeader("Dealer");

            DealerCards.Add(DealCard());
            DealerCards.Add(DealCard());

            Console.WriteLine($"The total value of dealer hand is {CalculateCardValues(DealerCards)}");
            return false;
        }

        private static int CalculateCardValues(List<Card> cards)
        {
            int value = 0;

            foreach (var card in cards)
            {
                if (value + card.Value > 21)
                    value++;

                value += card.Value;
            }

            return value;
        }

        private static void InitRound()
        {
            Console.Clear();
            _round++;
            _state = State.Indecisive;
            PlayerCards.Clear();
            DealerCards.Clear();
        }

        private static Card DealCard()
        {
            Card dealtCard = Deck.DealCard();
            Console.WriteLine($"Your card is {dealtCard.Face} of {dealtCard.Suit}");
            var card = dealtCard;
            Deck.RemoveCard(dealtCard);
            return card;
        }

        private static int GetBet()
        {
            int bet;
            Console.WriteLine("How much? (1-10)");
            string betString = Console.ReadLine();
            int.TryParse(betString, out bet);
            Console.WriteLine($"Your bet: ({bet})");
            return bet;
        }
    }
}