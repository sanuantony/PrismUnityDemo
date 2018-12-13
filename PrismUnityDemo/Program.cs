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

            IoCContainer ioCContainer = new IoCContainer();
            ioCContainer.Register<IAccount, CurrentAccount>();
            ioCContainer.Register<Customer, Customer>();
            var customer = ioCContainer.Resolve<Customer>();
            customer.DisplayBankAccountDetails();
            Console.ReadKey();
        }
    }
}






/*
IoCContainer ioCContainer = new IoCContainer();
ioCContainer.Register<IAccount, CurrentAccount>();
            var account = ioCContainer.Resolve<IAccount>();
account.Balance = 10000;
            account.Deposit(5050);
            Console.ReadKey();
    */
