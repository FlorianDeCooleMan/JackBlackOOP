namespace JackBlackOOP
{
    internal class Card
    {
        public enum Suit
        {
            Harten,
            Ruiten,
            Klaver,
            Schoppen
        }

        public enum Rank
        {
            Aas,
            Twee,
            Drie,
            Vier,
            Vijf,
            Zes,
            Zeven,
            Acht,
            Negen,
            Tien,
            Boer,
            Vrouw,
            Heer
        }

        private Suit suit;
        private Rank rank;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
        public override string ToString()
        {
            return $"{suit} {rank}";
        }
    }
}
