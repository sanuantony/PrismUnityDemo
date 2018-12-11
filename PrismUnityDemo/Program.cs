using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismUnityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var current = new CurrentAccount();
            current.Balance = 10000;
            current.Deposit(5050);
            Console.ReadKey();
        }
    }
}
