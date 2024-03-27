namespace JackBlackOOP
{
    internal class Dealer
    {
        public void Hit(Player player, Card card)
        {
            Console.WriteLine(card + " is toegevoegd aan je hand");
            player.HandKaarten.Add(card);
        }
    }
}
