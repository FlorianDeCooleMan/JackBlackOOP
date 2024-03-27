﻿using System;
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
            Player player1 = new Player();
            Player player2 = new Player();
            Hand hand = new Hand();
            Punten puntenDealer = new Punten(0);
            Wallet walletDealer = new Wallet(1000);

            Boolean life = true;
            while (walletDealer.getChips() > 0 & life == true)
            {
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("1 om te shufflen");
                System.Console.WriteLine("2 om je dek te zien");
                System.Console.WriteLine("3 om je chip saldo te zien");
                System.Console.WriteLine("4 om in te leggen");
                System.Console.WriteLine("5 om een punt toe te voegen");
                System.Console.WriteLine("6 om een kaart aan je hand toe te voegen");
                System.Console.WriteLine("7 om je hand te zien");
                System.Console.WriteLine("8 om uit het leven te stappen");
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
                    case "4":
                        Boolean goedGetal = false;
                        
                        while(goedGetal == false){
                            Console.WriteLine("Je saldo is: "+walletDealer.getChips());
                            string inleg = Console.ReadLine();
                            if (int.TryParse(inleg, out int inlegInt)&(walletDealer.getChips() - inlegInt >= 0))
                            {
                                Console.WriteLine("Je inleg is: " + inlegInt);
                                goedGetal = true;
                                walletDealer.setChips(walletDealer.getChips() - inlegInt);
                            }
                            else
                            {
                                Console.WriteLine("Dat mag niet! Vul een geldig getal in");
                                goedGetal = false;
                            }
                        }
                        Console.WriteLine("Je nieuwe saldo is: "+walletDealer.getChips());
                        break;
                    case "5":
                        puntenDealer.setPunten(puntenDealer.getPunten() +1);
                        Console.WriteLine("Je hebt nu "+puntenDealer.getPunten()+" punten");
                        break;
                        case "6":
                        player1.Hit(deck.drawCard());
                        break;
                    case "7":
                        player1.PrintHand();
                        break;
                    case "8":
                        System.Console.WriteLine("BOEM!");
                        Console.WriteLine("/\\/\\/\\/\\______________");
                        life = false;
                        break;
                    case "9":
                        player2.PrintHand();
                        break;
                    default:
                        Console.WriteLine("Nuh uh dat mag niet");
                        break;
                }
            }
        }
    }
}
