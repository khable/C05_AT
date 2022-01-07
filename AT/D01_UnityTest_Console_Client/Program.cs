using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Bryan Walton", 11.99);
            bankAccount.Credit(5.77);
            bankAccount.Debit(11.22);

            Console.WriteLine("Current balance is ${0}", bankAccount.Balance);
            Console.ReadKey();
        }
    }
}
