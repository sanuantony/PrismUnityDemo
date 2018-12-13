using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismUnityDemo
{
    public class CurrentAccount : IAccount
    {
        public int AccountID { get; set; } = 123;
        public long AccountNumber { get; set; } = 9895318686;
        public string Type { get; set; } = "Current Account";
        public string CustomerName { get; set; } = "Sanu Antony";
        public double Balance { get; set; }
        public double MinimumBalance { get; set; } = 2000;

        public void Deposit(double amount)
        {
            Console.WriteLine($"Opening balance is {Balance}");
            Console.WriteLine($"{amount} deposited to your account...");
            Console.WriteLine($"Avilable balance is {Balance += amount}");
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer name: {CustomerName} \nAccount Type : {Type}");
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return AccountNumber.ToString();
        }
    }
}
