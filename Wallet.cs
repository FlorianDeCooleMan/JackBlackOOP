namespace JackBlackOOP
{
    internal class Wallet
    {
        private int Chips;

        public Wallet(int Chips)
        {
            this.Chips = Chips;
        }
        public void setChips(int Chips)
        {
            this.Chips = Chips;
        }
        public int getChips()
        {
            return Chips;
        }
    }
}