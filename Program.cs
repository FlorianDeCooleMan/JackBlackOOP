using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JackBlackOOP
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Card card = new Card();
            Deck deck = new Deck();
            Dealer dealer = new Dealer();
            Player player = new Player();
            Wallet walletDealer = new Wallet(1000);
            Boolean life = true;
            while (life = true)
            {
                System.Console.WriteLine("1 om te shufflen");
                System.Console.WriteLine("2 om je dek te zien");
                System.Console.WriteLine("3 om je chip saldo te zien");
                string speel = Console.ReadLine();
                switch (speel)
                {
                    case "1":
                        deck.shuffle();
                        System.Console.WriteLine("je deck is geshuffled jippieee!");
                        break;
                    case "2":
                        deck.PrintDeck();
                        break;
                    case "3":
                        Console.WriteLine(walletDealer.getChips());
                        break;
                    default:
                        Console.WriteLine("nuh uh dat mag niet");
                        break;
                }
            }
        }
    }
}
