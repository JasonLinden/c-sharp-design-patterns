using _08___State.BankAccount.Context;
using _08___State.DVDPlayer.Context;
using _08___State.Steak.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___State
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new DVDPlayerContext();

            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
            player.PressMenuButton();
            player.PressPlayButton();
            player.PressPlayButton();
            
            Account account = new Account("Jim Johnson");

            // Apply financial transactions

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            //Let's cook a steak!
            SteakContext steakies = new SteakContext("T-Bone");

            // Apply temperature changes
            steakies.AddTemp(120);
            steakies.AddTemp(15);
            steakies.AddTemp(15);
            steakies.RemoveTemp(10); //Yes I know cooking doesn't work this way, bear with me.
            steakies.RemoveTemp(15);
            steakies.AddTemp(20);
            steakies.AddTemp(20);
            steakies.AddTemp(20);

            Console.ReadKey();
        }
    }
}
