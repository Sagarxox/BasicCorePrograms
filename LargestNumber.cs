using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    
    
        public static class LargestNumber
        {
            public static void Check()
            {
                int num1, num2, num3;
                Console.WriteLine(" Find the Largest Between Three Number ");
            Console.WriteLine("---------------------------------------------");

                Console.WriteLine("\n Enter the 1st number");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n Enter the 2nd number");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n Enter the 3rd number");
                num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("The 1st Number is the Greatest among three numbers");
                    }
                    else
                    {
                        Console.WriteLine("The 3rd Number is the Greatest among three numbers");
                    }
                }
                else if (num2 > num3)
                {
                    Console.WriteLine("second number is greatest among them");
                }
                else
                {
                    Console.WriteLine("third number is greatest among them");
                }
            }
        }
}
