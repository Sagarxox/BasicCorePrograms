using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Power2
    {
        public static void Power()
        {
            Console.WriteLine("enter a number :");
            int num ;

            double a ,b ;
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 31 || num <= 00)
            {
                Console.WriteLine(" enter value between  0 <= N < 31 ");
                
            } 
            else
            {
                
                a = (Math.Pow(2, num));
                Console.WriteLine("power of 2 of  {0}  is : {1}", num, a);
                Console.WriteLine("printing table of power 2 of {0} : ", num);
                for (int i = 1; i <= num; i++)
                {
                    b = (Math.Pow(2, i));

                    // for (int j = 0; j < i; j++)
                    //{
                    //  Console.WriteLine(" {0} {1} {3} {4}", i, j, num, a);
                    //}
                    Console.WriteLine("power of 2 of {0} is : {1}", i, b);
                }


            }



        }

        
    }


}

