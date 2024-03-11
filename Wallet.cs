namespace JackBlackOOP
{
    internal class Wallet
    {
        private int chips;

        public Wallet(int chips)
        {
            this.chips = chips;
        }
        public void setChips(int chips)
        {
            this.chips = chips;
        }
        public int getChips()
        {
            return chips;
        }
    }
}