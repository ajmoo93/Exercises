using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{

    class Dealer
    {
        
        public int chips;
        public CardDeck deck;
        public List<Card> playerHand;
        public List<Card> DealerHand;


        public void Hand()
        {
            chips = 100;
            deck = new CardDeck();
            deck.shuffle();

            while (chips > 100)
            {
                DealHand();
                Console.WriteLine("Press a key for next hand ");
                ConsoleKeyInfo userInput = Console.ReadKey(true);
            }

            Console.WriteLine("You have lost, play again!");
            Console.ReadLine();
        }
        public void DealHand()
        {
            if (deck.AmountOfRemainingCards() < 0)
            {
                deck.Deck();
                deck.shuffle();

            }
            Console.WriteLine("Cards Remaining: {0}", deck.AmountOfRemainingCards());
            Console.WriteLine("Current chips: {0}", chips);
            Console.WriteLine("How much do you want to bet? (1 - {0})", chips);
            string input = Console.ReadLine().Trim().Replace(" ", "");
            int betAmount;

            while (!Int32.TryParse(input, out betAmount) || betAmount < 1 || betAmount > chips) 
            {
                Console.WriteLine(" Bad amount, Try anothet amount (1 - {0})", chips);
                input = Console.ReadLine().Trim().Replace(" ", "");

            }
            Console.WriteLine();

            playerHand = new List<Card>();
            playerHand.Add(deck.DrawCard());
            playerHand.Add(deck.DrawCard());

            foreach (Card carde in playerHand)
            {
                if (carde.Face == Face.Ace)
                {
                    carde.Value += 10;
                    break;
                }
            }
            Console.WriteLine("Player");
            Console.WriteLine("Card one: {0} of {1}", playerHand[0].Face, playerHand[0].suit);
            Console.WriteLine("Card two: {0} of {1}", playerHand[1].Face, playerHand[1].suit);
            Console.WriteLine("Card total: {0}", playerHand[0].Value+ + playerHand[1].Value);
            Console.WriteLine();
            DealerHand = new List<Card>();
            DealerHand.Add(deck.DrawCard());
            DealerHand.Add(deck.DrawCard());
            foreach (Card carde in DealerHand)
            {
                if (carde.Face == Face.Ace)
                {
                    carde.Value += 10;
                    break;
                }
            }
            Console.WriteLine("[Delaer]");
            Console.WriteLine("Card 1: {0} of {1}", DealerHand[0].Face, DealerHand[1].suit);
            Console.WriteLine("Card 2: [Hole Card]");
            Console.WriteLine("Total: {0}\n", DealerHand[0].Value);

            
                do
                {
                    Console.WriteLine("what to you want?  [S]Stand, [H]Hit");
                    ConsoleKeyInfo userinput = Console.ReadKey(true);
                    while (userinput.Key != ConsoleKey.S && userinput.Key != ConsoleKey.H)
                    {
                        Console.WriteLine("A valid option is needed,  try again");
                        userinput = Console.ReadKey(true);
                    }
                    Console.WriteLine();
                    switch (userinput.Key)
                    {
                        case ConsoleKey.S:
                            Console.WriteLine("Dealer");
                            Console.WriteLine("Card one: {0} of {1}", DealerHand[0].Face, DealerHand[1].suit);
                            Console.WriteLine("Card two: {0} of {1}", DealerHand[1].Face, DealerHand[1].suit);

                            int DealersAmount = 0;
                            foreach (Card carde in DealerHand)
                            {
                                DealersAmount += carde.Value;
                            }
                            while (DealersAmount < 17)
                            {
                                DealerHand.Add(deck.DrawCard());
                                DealersAmount = 0;
                                foreach (Card carde in DealerHand)
                                {
                                    DealersAmount += carde.Value;
                                }
                                Console.WriteLine("Card {0}: {1} of {2}", DealerHand.Count, DealerHand[DealerHand.Count - 1].Face, playerHand[playerHand.Count - 1].suit);

                            }
                            DealersAmount = 0;
                            foreach (Card carde in DealerHand)
                            {
                                DealersAmount += carde.Value;

                            }

                            Console.WriteLine("Amount: {0}", DealersAmount);

                            if (DealersAmount > 21)
                            {
                                Console.WriteLine("Dealer Is busted, You won: ({0} chips", betAmount);
                                chips += betAmount;
                                return;
                            }
                            else
                            {
                                int playersAmount = 0;
                                foreach (Card carde in playerHand)
                                {
                                    playersAmount += carde.Value;
                                }
                                if (DealersAmount > playersAmount)
                                {
                                    Console.WriteLine("Dealer had {0} and player has {1} dealer Wins!", DealersAmount, playersAmount);
                                    chips -= betAmount;
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine(" Player has {0} and dealer has {1} Player wins!", playersAmount, DealersAmount);
                                    chips += betAmount;
                                    return;
                                }
                            }
                          

                        case ConsoleKey.H:
                            playerHand.Add(deck.DrawCard());
                            Console.WriteLine("Hitted {0} of {1}", playerHand[playerHand.Count - 1].Face, playerHand[playerHand.Count - 1].suit);
                            int ValueOfCards = 0;
                            foreach (Card carde in playerHand)
                            {
                                ValueOfCards = carde.Value;
                            }
                            Console.WriteLine("Card value is : {0}", ValueOfCards);
                            if (ValueOfCards > 21)
                            {
                                Console.WriteLine("Busted Little Kid");
                                chips -= betAmount;
                                break;
                            }
                            else if (ValueOfCards == 21)
                            {
                                Console.WriteLine("You have a good hand");
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                           

                        default:
                            break;
                    }
                
                    Console.ReadLine();
                }
                while (true);
                }

                }
        }



//bool insurance = false; ;

//if (DealerHand[0].Face == Face.Ace)
//{
//    Console.WriteLine("Insurance? (y / n)");
//    string userInput = Console.ReadLine();

//    while (userInput != "y" && userInput != "n")
//    {
//        Console.WriteLine("Could not understand. Insurance? (y / n)");
//        userInput = Console.ReadLine();
//    }

//    if (userInput == "y")
//    {
//        insurance = true;
//        //chips -= betAmount / 2;
//        Console.WriteLine("\n[Insurance Accepted!]\n");
//    }
//    else
//    {
//        insurance = false;
//        Console.WriteLine("\n[Insurance Rejected]\n");
//    }
//}
//if (DealerHand[0].Face == Face.Ace || DealerHand[0].Value == 10)
//    Console.WriteLine("Dealer checks blackjack");

//if (DealerHand[0].Value + DealerHand[0].Value == 21)
//{
//    //Console.WriteLine("Dealer");
//    //Console.WriteLine(" Card one: {0} of {1}", DealerHand[0].Face, DealerHand[0].suit);
//    //Console.WriteLine("Card two: {0} of {1}", DealerHand[0].Face, DealerHand[1].suit);
//    //Console.WriteLine("Card total: {0}", DealerHand[0].Value + DealerHand[1].Value);

//    int amountLost = 0;

//    if (playerHand[0].Value + playerHand[1].Value == 21 && insurance)
//    {
//        amountLost = betAmount / 2;
//        chips -= betAmount / 2;
//    }
//    else if (playerHand[0].Value + playerHand[1].Value != 21 && !insurance)
//    {
//        amountLost = betAmount + betAmount / 2;
//        chips -= betAmount + betAmount / 2;
//    }

//    Console.WriteLine("You lost {0} chips", amountLost);

//    return;
//}
//else
//{
//    Console.WriteLine("Dealer does not have a blackjack, moving on...\n");
//}



//    if (playerHand[0].Value + playerHand[0].Value == 21)
//    {
//        Console.WriteLine("COngratulations you got blackjack  ({0} chips)", betAmount + betAmount / 2);
//        chips += betAmount + betAmount / 2;
//        return;
//    }