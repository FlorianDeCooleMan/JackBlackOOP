namespace JackBlackOOP
{
    internal class Hand
    {
        List<Card> HandKaarten = new List<Card>();

        public void HandAdd()
        {
            Card EersteKaart = Deck.cardList[0];
            Console.WriteLine(EersteKaart + " is toegevoegd aan je hand");
            cardList.RemoveAt(0);
            HandKaarten.Add(EersteKaart);
        }
        public void PrintHand()
        {
            if (HandKaarten.Count != 0)
            {
                Console.WriteLine("Je Hand:");
                foreach (Card card in HandKaarten)
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