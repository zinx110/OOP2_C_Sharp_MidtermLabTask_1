using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_MidtermLabTask_1

{
    class Contact
    {
        private string personName;
        private string personId;
        private int age;
        private string mobileNumber;
        private char gender;

        public string PersonName
        {
            get { return personName; }
            set { personName = value; }

        }
        public string PersonId
        {
            get { return personId; }
            set { personId = value; }

        }
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }

        }
        public char Gender
        {
            get { return gender; }
            set {
                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else { Console.WriteLine("Invalid Gender"); }
            
            
            }

        }




        public Contact() // empty constructor
        {
 
        
        }


        public Contact(string name, string id,int age, string num, char gender) // parameterized constructor
        {
            PersonName = name;
            PersonId = id;
            Age = age;
            MobileNumber = num;
            Gender = gender;


        }

        public void ShowPersonInfo()
        {
            Console.WriteLine("PersonName: "+PersonName);
            Console.WriteLine("Id: "+PersonId);
            Console.WriteLine("Age: "+Age);
            Console.WriteLine("Mobile Number: "+MobileNumber);
            Console.WriteLine("Gender: "+Gender);
        
        }


        public void DetectMobileOperator()
        {
            string a = MobileNumber.Substring(0, 3);
            switch (a)
            {
                case "017":
                    Console.WriteLine("GP");
                    break;
                case "018":
                    Console.WriteLine("Robi");
                    break;
                case "019":
                    Console.WriteLine("Banglalink");
                    break;
                default:
                    Console.WriteLine("unIdentified");
                    break;

            }
        
        }

    }
}