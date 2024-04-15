namespace JackBlackOOP
{
    internal class Player
    {
        internal List<Card> HandKaarten = new List<Card>();
        internal Wallet Wallet { get; }

        public Player(int Chips)
        {
            Wallet = new Wallet(Chips);
        }

        public void Hit()
        {
            Console.WriteLine("Ik wil Hitten!:");
        }

        public void Stand()
        {
            Console.WriteLine("Ik wil Standen!:");
        }

        public void PrintHand()
        {
            if (HandKaarten.Count != 0)
            {
                Console.WriteLine("Je Hand:");
                foreach (Card card in HandKaarten)
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
            foreach (Card card in HandKaarten)
            {
                handWaarde += card.GetValue();
            }
            return handWaarde;
        }
        public void PrintWallet()
        {
            Console.WriteLine(Wallet.getChips());
        }
    }
}
