using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_1
{
    class Mobile
    {

        private string mobileOwnerName;
        private string mobileNumber;
        private int mobileBalance;
        private string mobileOSName;
        private bool _lock; // "lock" is showing as keyword 

        public string MobileOwnerName
        {
            get { return mobileOwnerName; }
            set { mobileOwnerName = value; }
        }
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        public int MobileBalance
        {
            get { return mobileBalance; }
            set {  mobileBalance= value; }
        }
        public string MobileOSName
        {
            get { return mobileOSName; }
            set {  mobileOSName= value; }
        }
        public bool Lock
        {
            get { return _lock; }
            set {_lock  = value; }
        }

        public Mobile()
        {
            Console.WriteLine("Sim Added");
        }


        public Mobile(string name,string num, int bal, string OS, bool l )
        {
            MobileOwnerName = name;
            MobileNumber = num;
            MobileBalance = bal;
            MobileOSName = OS;
            Lock = l;
            Console.WriteLine("Sim Added");
        }

        public void ShowInfo()
        {
            if (Lock == false)
            {
                Console.WriteLine("Mobile Owner Name : " + MobileOwnerName);
                Console.WriteLine("Mobile Number : " + MobileNumber);
                Console.WriteLine("Balance : " + MobileBalance);
                Console.WriteLine("OS : " + MobileOSName);
                Console.WriteLine("Locked Status : " + Lock);
            }
            else
            {
                Console.WriteLine("Phone is Locked");
            }
        }

        public void Recharge(int Amount)
        {
            if (Lock == false)
            {
                MobileBalance=MobileBalance+Amount;
                
                Console.WriteLine("Recharged amount : " + Amount);
                Console.WriteLine("New Balance : " + MobileBalance);
            }
            else
            {
                Console.WriteLine("Phone is Locked");
            }
        }

        public void CallSomeone(int duration) // assuming duration is in seconds
        {
            if (Lock == false)
            {
                int cost = Convert.ToInt32(Math.Ceiling((Convert.ToDouble(duration) / 60)));


                MobileBalance = MobileBalance - cost;

                Console.WriteLine("Talked for the duration of " + duration +" seconds.");
                Console.WriteLine("Charged : " + cost);
                Console.WriteLine("New Balance : " + MobileBalance);
            }
            else
            {
                Console.WriteLine("Phone is Locked");
            }
        }

           



    }
}
