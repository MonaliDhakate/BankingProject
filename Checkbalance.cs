using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingProjectConsole
{
    public class Checkbalance: Credit
    {
       
       public void balance(double credit)
        {
            
            double balanced = credit;
            Console.WriteLine($"Your available balanced is {balanced}");
            Console.WriteLine("Thank you..!!");
            //Withdraw wt = new Withdraw();
            //wt.withdraw(balanced);
        }

        
    }
}
