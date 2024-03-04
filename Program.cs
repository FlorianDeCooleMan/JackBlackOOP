using System;
using System.Collections.Generic;

namespace JackBlackOOP
{
    internal class Program
    {
        static void Main()
        {
            Card card1 = new Card();
            Dealer dealer = new Dealer();
            Wallet walletDealer = new Wallet(1000);
            Console.WriteLine(walletDealer.getChips());
        }
    }
}
