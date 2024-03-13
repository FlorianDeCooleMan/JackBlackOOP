namespace JackBlackOOP
{
    internal class Deck
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
        List<string> HandKaarten = new List<string>();

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
        public void HandAdd()
        {
            String EersteKaart = cardList[0];
            Console.WriteLine(EersteKaart+" is toegevoegd aan je hand");
            cardList.RemoveAt(0);
            HandKaarten.Add(EersteKaart);
            
        }
        public void PrintHand()
        {
            if (HandKaarten.Count != 0)
            {
                Console.WriteLine("Je Hand:");
                foreach (string card in HandKaarten)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Je hand is leeg :(");
            }
        }
    }
}