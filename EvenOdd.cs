using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class EvenOdd
    {
        public static void Check()
        
        {
                int a;
                Console.WriteLine(" Check Number is Even or Odd");
            Console.WriteLine("---------------------------------");

                Console.WriteLine("\n Enter a Number");
                a = Convert.ToInt32(Console.ReadLine());

                if (a % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number is Odd");
                }
        }
    }
}
