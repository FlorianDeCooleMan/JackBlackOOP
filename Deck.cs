namespace JackBlackOOP
{
    internal class Deck
    {
        internal static List<Card> cardList = new List<Card>();

        public Deck()
        {
            createUniqueDeck();
        }

        private void createUniqueDeck()
        {
            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.Rank rank in Enum.GetValues(typeof(Card.Rank)))
                {
                    Card card = new Card(suit, rank);
                    cardList.Add(card);
                }
            }
        }
        private void ShuffleCardsInPlace(List <Card> cardList)
        {
            Random random = new Random();
            int n = cardList.Count;

            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = cardList[k];
                cardList[k] = cardList[n];
                cardList[n] = value;
            }
        }

        //kleine print voor de leuk
        public void PrintDeck()
        {
            Console.WriteLine("Inhoud van het deck:");
            foreach (Card card in cardList)
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