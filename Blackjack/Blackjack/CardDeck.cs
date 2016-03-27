using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class CardDeck
    {
        // skapa En Lista av Card
        private List<Card> cards;
        // Gör en metod för CardDeck
        public CardDeck()
        {
            this.Deck();

        }
        // <Gör en void metod för Deck
        public void Deck()
        {
            // nu tar vi Cards i listan och gör en ny Lista med Cards
            cards = new List<Card>();
            // Lägg i en for lop i en for lop för att räkna alla 52 korten
            for (int i = 0; i < 4; i++)// 
            {
                // 13 * 4 = 52
                for (int j = 0; j < 13; j++)
                {
                    // Här Lägger vi till kort som får en suit och face Hjärter osv och ett värde.
                    cards.Add(new Card() { suit = (Suit)i, Face = (Face)j });

                    if (j <= 7)
                        cards[cards.Count - 1].Value = j + 1;
                    else
                        cards[cards.Count - 1].Value = 10;
                }
            }
        }
                    // Nu gör vi en annan metod för att kunna ranomma korten 
                    // så man inte får samma kort hela tiden.
          public void shuffle()
        {
            // Skapa en ranom Ran
            Random Ran = new Random();
            int A = cards.Count;
            // en While loop för att randomma hela tiden.
            while (A > 1)
            {
                A--;
                int C = Ran.Next(A + 1);
                Card card = cards[A];
                cards[A] = cards[C];
                cards[C] = card;

            }
        }

        
            public Card DrawCard()
        {
            if(cards.Count <= 0)
            {
                Deck();
                shuffle();
            }

            Card ReturnACard = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return ReturnACard;
        }
        public int AmountOfRemainingCards()
        {
            return cards.Count;
        }

        public void DeckPrinter()
        {
            int i = 1;
            foreach(Card carde in cards)
            {
                Console.WriteLine(" Card {0}: {1} of {2}. Value is {3] ", carde.suit, carde.Face, carde.Value);
                i++;
            }
        }
     }
  }
  