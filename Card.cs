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

        private List<string> cardList;

        public Deck()
        {
            cardList = CardList1();
        }

        private List<string> CardList1()
        {
            List<string> CardList2 = new List<string>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    string card = $"{suit} {rank}";
                    CardList2.Add(card);
                }
            }

            return CardList2;
        }
    }
}