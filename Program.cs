using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices.JavaScript;
using System.Text;

namespace JackBlackOOP
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Deck deck = new Deck();
            Dealer dealer = new Dealer();
            Hand hand = new Hand();
            Punten puntenDealer = new Punten(0);
            Wallet walletDealer = new Wallet(1000);

            List<int> PlayerCountList = new List<int>();
            List<Player> players = new List<Player>();


            Boolean menu = true;
            Boolean life = false;
            while (menu == true)
            {
                System.Console.WriteLine("Hallo dealer! Welkom bij BlackJack");
                System.Console.WriteLine("met hoeveel spelers wil je spelen? max 4");
                string playerCount = Console.ReadLine();
                if (playerCount != null && int.TryParse(playerCount, out int count) && count <= 4)
                {
                    life = true;
                    menu = false;

                    for (int i = 1; i <= count; i++)
                    {
                        Player player = new Player();
                        players.Add(player);
                        PlayerCountList.Add(i);
                    }
                }
                else
                {
                    life = false;
                }
            }

/*            while (walletDealer.getChips() > 0 & life == true)*/
            {
                foreach (Player player in players)
                {
                    dealer.Hit(player, deck.drawCard());
                    dealer.Hit(player, deck.drawCard());
                }
                    foreach (Player player in players)
                {
                    Random rnd = new Random();
                    int dice = rnd.Next(1, 3);
                    if (dice == 1)
                    {
                        player.Hit();
                    }
                    else
                    {
                        player.Stand();
                    }
                }

            }
        }
    }
}
