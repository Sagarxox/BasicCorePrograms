using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
  
     public static class QuotientRemainder
    {
        public static void Check()
        {
            int divident , divisor  , remainder;

            
            Console.WriteLine("enter divident");

            divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter divisor");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = Math.DivRem(divident, divisor, out remainder);


            Console.WriteLine("\n Divident : {0}  Divisor : {1} ", divident, divisor);
            Console.WriteLine("Quotient =   \n  "+ quotient);
            Console.WriteLine( "remainder = " +remainder );
        }
    }

}
