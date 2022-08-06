using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_1
{
    class Account
    {


        private string accName;
        private string acid;
        private int balance;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }


        }
        public string Acid
        {
            get { return acid; }
            set { acid = value; }


        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }


        }

        public Account() // empty constructor
        {
            Console.WriteLine("Object created");
        }

        public Account(string name,string acid, int bal) // parameterized constructor
        {
            AccName = name;
            Acid = acid;
            Balance = bal;

            Console.WriteLine("Object created");
        }


        public void Deposit(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("Amount deposited");
        }
        public void Withdraw(int amount)
        {
            Balance = Balance - amount;
            Console.WriteLine("Amount withdrawn");
        }


        public void Transfer(int amount, Account reciever)
        {
            reciever.Deposit(amount);
            Balance = Balance - amount;
            Console.WriteLine("Amount withdrawn");
        }



    }
}
