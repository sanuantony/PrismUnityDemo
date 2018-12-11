using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismUnityDemo
{
    public class CurrentAccount : IAccount
    {
        public int AccountID { get; set; }
        public long AccountNumber { get; set; }
        public string Type { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }
        public double MinimumBalance { get; set; }

        public void Deposit(double amount)
        {
            Console.WriteLine($"Opening balance is {Balance}");
            Console.WriteLine($"{amount} deposited to your account...");
            Console.WriteLine($"Avilable balance is {Balance += amount}");
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
