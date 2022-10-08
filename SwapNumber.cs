using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class SwapNumber
    {
         public static void Number()
        {
            Console.WriteLine("enter first number");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------");
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.Write("After swap a= " + a + " b= " + b );

        }
    }
}
