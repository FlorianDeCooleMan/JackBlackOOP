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
            Aas = 1,
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
        private int value;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;

            switch (rank)
            {
                case Rank.Aas:
                    value = 1;
                    break;
                case Rank.Twee:
                case Rank.Drie:
                case Rank.Vier:
                case Rank.Vijf:
                case Rank.Zes:
                case Rank.Zeven:
                case Rank.Acht:
                case Rank.Negen:
                case Rank.Tien:
                    value = (int)rank;
                    break;
                case Rank.Boer:
                case Rank.Vrouw:
                case Rank.Heer:
                    value = 10;
                    break;
            }
        }
        public int GetValue()
        {
            return value;
        }
        public override string ToString()
        {
            return $"{suit} {rank}";
        }
    }
}
