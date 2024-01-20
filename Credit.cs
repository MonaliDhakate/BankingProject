using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingProjectConsole
{
    public class Credit: bankAccount
    {
        public double amount =0.00;
        public double credit;


        public void CreditAmount() 
        {
            Console.WriteLine("please enter account no");
            double acc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter otp");
            int otp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter how many amount u want to credit");
            double money=Convert.ToDouble(Console.ReadLine());
            if (money < 0)
            {
                Console.WriteLine("Please enter valid amount");

            }
            else
            {
                credit = amount + money;
                Console.WriteLine($"You succefully credit of amount {credit}");
               
            }
            Console.WriteLine("you want to check amount.??");
            char ans=Convert.ToChar(Console.ReadLine());
            if (ans == 'Y')
            {
                Checkbalance chk = new Checkbalance();
                chk.balance(credit);
            }
            else
            {
                Console.WriteLine("Thank you..!!");
            }
           


        }
    }
}
