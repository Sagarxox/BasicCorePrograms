using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Factors
     {
        public static void PrimeFactor ()
        {
           
                int n, i;
                Console.WriteLine("Enter the Number:");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Factors of {0}:" ,n);
                for (i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadLine();
            
        }

    }
}
