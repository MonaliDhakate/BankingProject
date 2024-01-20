using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingProjectConsole
{
    public class Withdraw:Credit
    {
        Checkbalance ck=new Checkbalance(); 
        public void withdraw(double bal)
        {
            
            Console.WriteLine("please enter account no");
            double acc=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter otp");
            int otp= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter how many amount u want to withdraw");
            double money = Convert.ToDouble(Console.ReadLine());

            double tot = bal - money;
            

            if (tot < 0)
            {
                Console.WriteLine("please enter valid amount");
            }
            else
            {
                Console.WriteLine($"Your succefully withdraw of amount {money}");
            }
           
            ck.balance(tot);

        }
    }
}
