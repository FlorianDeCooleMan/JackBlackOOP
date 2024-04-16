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
            Wallet walletDealer = new Wallet(10000);

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
                        Player player = new Player(1000);
                        players.Add(player);
                    }
                }
                else
                {
                    life = false;
                }
            }
            System.Console.WriteLine("Oke dan kunnen we nu beginnen met het spelen!");
            System.Console.WriteLine("Wil je het deck shufflen? y/n");
            string shuffle = Console.ReadLine();
            switch (shuffle)
            {
                case "y":
                    deck.shuffle(); System.Console.WriteLine("Je deck is geschud!"); break;
                case "n":
                    System.Console.WriteLine("Oke dan gaan we door zonder te schudden"); break;
                default:
                    System.Console.WriteLine("Dat mag niet! dat worden puntjes aftrek!"); break;

            }
            foreach (Player player in players)
            {
                if (player.Wallet.getChips() > 500) {
                    System.Console.WriteLine("Hmmm, ik zet 400 in!");
                int currentChips = player.Wallet.getChips();
                player.Wallet.setChips(player.Wallet.getChips()-400);
                }
                else
                {
                    System.Console.WriteLine("Alles of niets! Ik zet alles in!");
                    int inzet = player.Wallet.getChips();
                    player.Wallet.setChips(player.Wallet.getChips() - player.Wallet.getChips());
                }
                
                Console.WriteLine("Wallet van speler bijgewerkt naar: " + player.Wallet.getChips() + " chips.");
            }

            while (walletDealer.getChips() > 0 & life == true & deck.cardList.Count > 10)
            {
/*                System.Console.WriteLine(deck.cardList.Count);*/
                foreach (Player player in players)
                {

                    dealer.Hit(player, deck.drawCard());
                    dealer.Hit(player, deck.drawCard());
                    dealer.DealerHit(deck.drawCard());
                    dealer.PrintHand();
                    Random rnd = new Random();
                    int dice = rnd.Next(1, 3);
                    if (player.HandWaarde() <= 16 & dice == 1)
                    {
                        player.Hit();
                    }
                    else
                    {
                        player.Stand();
                    }
                    System.Console.WriteLine("ga je deze lieve jongeman een kaartje geven? y/n");
                    string geef = Console.ReadLine();
                    switch (geef)
                    {
                        case "y":
                            dealer.Hit(player, deck.drawCard()); System.Console.WriteLine("je hebt het kaartje gegeven!"); break;
                        case "n":
                            System.Console.WriteLine("je hebt het kaartje niet gegeven!"); break;
                        default:
                            System.Console.WriteLine("dat mag niet! dat worden puntjes aftrek!"); break;
                    }
                    dealer.HandKaartenDealer.Clear();
                    System.Console.WriteLine("----------------------------------");
                }

            }
        }
    }
}
