using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismUnityDemo
{
    class Customer
    {
        private IAccount _account;
        public Customer(IAccount account)
        {
            _account = account;
        }
        public void DisplayBankAccountDetails()
        {
            _account.DisplayCustomerDetails();
        }
    }
}
