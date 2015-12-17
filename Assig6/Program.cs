using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig6
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(250);
            account.Deposit(100);
            account.Withdraw(300);
            account.Withdraw(100);
            account.Deposit(-100);
            account.Withdraw(-20);

            Console.ReadLine();

        }
    }
}
