using System.Numerics;

namespace JackBlackOOP
{
    internal class Dealer
    {
        internal List<Card> HandKaartenDealer = new List<Card>();
        public void Hit(Player player, Card card)
        {
            player.HandKaarten.Add(card);
            Console.WriteLine(card + " is toegevoegd aan je hand");
        }
        public void DealerHit(Card card)
        {
           HandKaartenDealer.Add(card);
        }
        public void PrintHand()
        {
            if (HandKaartenDealer.Count != 0)
            {
                Console.WriteLine("De hand van de dealer is:");
                foreach (Card card in HandKaartenDealer)
                {
                    Console.WriteLine(card);
                    Console.WriteLine(card.GetValue());
                }
            }
            else
            {
                Console.WriteLine("Je hand is leeg :(");
            }
        }

        public int HandWaarde()
        {
            int handWaarde = 0;
            foreach (Card card in HandKaartenDealer)
            {
                handWaarde += card.GetValue();
            }
            return handWaarde;
        }
    }
}
