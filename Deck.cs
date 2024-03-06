namespace JackBlackOOP
{
    internal class Deck
    {
        public enum Suit
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }

        public enum Rank
        {
            Ace,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
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
                    string card = $"{rank} of {suit}";
                    CardList2.Add(card);
                }
            }

            return CardList2;
        }
        private void ShuffleCardsInPlace(List<string> cardList)
        {
            Random random = new Random();
            int n = cardList.Count;

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string value = cardList[k];
                cardList[k] = cardList[n];
                cardList[n] = value;
            }
        }

        //kleine print voor de leuk
        public void PrintDeck()
        {
            Console.WriteLine("Inhoud van het deck:");
            foreach (string card in cardList)
            {
                Console.WriteLine(card);
            }
        }
        public void shuffle()
        {
            ShuffleCardsInPlace(cardList);
        }

    }
}