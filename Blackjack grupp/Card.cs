namespace BlackJack6
{
    public enum Suits
    {
        Hearts,
        Clubs,
        Spades,
        Diamonds,
    }
    public enum Faces
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14,
    }
    class Card
    {
        public int Value { get; set; }
        public Suits Suit { get; set; }
        public Faces Face { get; set; }
    }
}