namespace JackBlackOOP
{
    internal class Player
    {
        Boolean standbool = false;
        Boolean hitbool = false;

        internal List<Card> HandKaarten = new List<Card>();
        internal Wallet Wallet { get; }

        public Player(int Chips)
        {
            Wallet = new Wallet(Chips);
        }

        public void Hit()
        {
            Console.WriteLine("Ik wil Hitten!:");
            hitbool = true;
        }
        public bool GetHitBool()
        {
            return hitbool;
        }

        public void Stand()
        {
            Console.WriteLine("Ik wil Standen!:");
            standbool = true;
        }
        public bool GetStandBool()
        {
            return standbool;
        }

        public void PrintHand()
        {
            if (HandKaarten.Count != 0)
            {
                Console.WriteLine("De Hand van de speler:");
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
