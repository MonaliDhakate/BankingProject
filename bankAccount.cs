using System;

namespace bankingProjectConsole
{
    public class bankAccount
    {

        public string Name;
        public void details()
        {
            Console.WriteLine("enter your full name");
            string name=Console.ReadLine();
            Name = name;
            Console.WriteLine("enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            agecheck(age);

            Console.WriteLine("enter your phone no");
            double phnno=Convert.ToDouble(Console.ReadLine());
            pancheck();

            Console.WriteLine("enter your Adharcard no");
            double adhar =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter your Gender");
            char gender=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter your Address");
            string address=Console.ReadLine();
            Console.WriteLine("enter your City");
            string city=Console.ReadLine();
            Console.WriteLine("enter your Pincode");
            int pincode=Convert.ToInt32(Console.ReadLine());

            Credit cd = new Credit();
            cd.CreditAmount();
        }

        public void agecheck(int age)
        {
            if( age>0 && age<=18)
            {
                Console.WriteLine("You are eligible to create minor account");
            }
            else if(age>18 && age<=50)
            {
                Console.WriteLine("You are eligible to create salary account");
            }
            else
            {
                Console.WriteLine("You are eligible to create pensioned account");
            }
        }

        public void pancheck()
        {
            Console.WriteLine("Do u have pancard..??");
            char chk=Convert.ToChar(Console.ReadLine());    
            if(chk=='Y')
            {
                Console.WriteLine("Enter panacard no");
            }
            else
            {
                Console.WriteLine("ok fine..!!");
            }
            double pancard = Convert.ToDouble(Console.ReadLine());
        }
      
    }
}