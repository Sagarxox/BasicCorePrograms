using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    
        public class LeapYear
        {
            public static void Check()
            {
                int year;
                Console.WriteLine("\nCheck Wheather Year is Leap year or Not");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Enter Four Digit Year Number");
            Console.WriteLine("-------------------------------------- \n");
                year = int.Parse(Console.ReadLine());

                if (year >= 1000 && year <= 9999)
                {
                    if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                    {
                        Console.WriteLine("Is Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Is Not a Leap Year");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a Valid Year");
                }

            }
        }
    
}