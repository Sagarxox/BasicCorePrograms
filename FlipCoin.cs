using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public static class FlipCoin
    {
        public static void CalculatePercentage()

        {
            Console.WriteLine("please enter the value for number of flips");
            
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;
            int flipCoin = Convert.ToInt32(Console.ReadLine());
            if (flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("number :" + number);
                    if (number == 0)
                    {
                        TailCount++;

                    }
                    else
                    {
                        HeadCount++;
                    }
                }
                Console.WriteLine("the count of head is : " +HeadCount);
                Console.WriteLine("the count of tail is : " +TailCount);
                HeadPercentage = HeadCount * 100 / flipCoin;
                TailPercentage = TailCount * 100 / flipCoin;

                Console.WriteLine("Head percentage is : " + HeadPercentage); 
                Console.WriteLine("Tail percentage is : " + TailPercentage);
            }
            else
            {
                Console.WriteLine("please enter positive and greater then zero");
            }
        }
    }        
}
