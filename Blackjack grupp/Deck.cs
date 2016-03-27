using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack6
{
    class Deck
    {
        private List<Card> Cards { get; set; }

        public Deck()
        {
            InitCards();
            ShuffleDeck();
        }

        public Card DealCard()
        {
            Card card = Cards.First();

            return Cards.First();
        }

        public void ShuffleDeck()
        {
            List<Card> tempList = new List<Card>();
            Random random = new Random();
            int numberofCards = Cards.Count;
            for (int i = 0; i < numberofCards; i++)
            {
                int randomNbr = random.Next(0, Cards.Count());
                Card selected = Cards.ElementAt(randomNbr);
                tempList.Add(selected);
                Cards.Remove(selected);
            }
            Cards.AddRange(tempList);

        }

        public void InitCards()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    Cards.Add(new Card() { Suit = (Suits)i, Face = (Faces)j });
                    if (j <= 9)
                        Cards[Cards.Count - 1].Value = j;
                    else if (j == 14)
                        Cards[Cards.Count - 1].Value = 11;
                    else
                        Cards[Cards.Count - 1].Value = 10;
                }
            }
        }

        public void RemoveCard(Card dealtCard)
        {
            Cards.Remove(dealtCard);
        }

        public bool HasCards()
        {
            return Cards.Any();
        }
    }
}