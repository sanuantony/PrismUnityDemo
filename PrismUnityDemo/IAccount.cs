using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismUnityDemo
{
    interface IAccount
    {
        int AccountID { get; set; }
        long AccountNumber { get; set; }
        string Type { get; set; }
        string CustomerName { get; set; }
        double Balance { get; set; }
        double MinimumBalance { get; set; }
        void Withdraw(double amount);
        void Deposit(double amount);
        void DisplayCustomerDetails();
    }
}
