namespace JackBlackOOP
{
    internal class Player
    {
        internal List<Card> HandKaarten = new List<Card>();
        public void Hit(Card card)
        {
                Console.WriteLine(card + " is toegevoegd aan je hand");
               
                HandKaarten.Add(card);
        }
        public void Stand()
        {
/*            hier komt de stand*/
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