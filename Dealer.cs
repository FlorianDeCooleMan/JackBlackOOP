namespace JackBlackOOP
{
    internal class Dealer
    {
        public void Hit(Player player, Card card)
        {
            player.HandKaarten.Add(card);
            Console.WriteLine(card + " is toegevoegd aan je hand");
        }
    }
}
