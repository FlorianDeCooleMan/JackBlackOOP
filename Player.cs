namespace JackBlackOOP
{
    internal class Player
    {
        public void Hit()
        {
            for (int i = 0; i < 2; i++)
            {
                Card EersteKaart = Deck.cardList[0];
                Console.WriteLine(EersteKaart + " is toegevoegd aan je hand");
                Deck.cardList.RemoveAt(0);
                Hand.HandKaarten.Add(EersteKaart);
            }
        }
        public void Stand()
        {
/*            hier komt de stand*/
        }
    }
}