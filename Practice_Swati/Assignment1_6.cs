using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assignment1_6
    {
        static void Main()
        {
            int sum = 0;
            int count = 0;

            Console.WriteLine("Enter 10 positive Numbers :\n");

            while (count < 10)
            {

                int num = Int16.Parse(Console.ReadLine());

                if (num > 0)
                {
                    sum = sum + num;
                    count++;
                }
                else
                {
                    Console.WriteLine("Please enter Positive Numbers\n");
                }

            }
            Console.WriteLine($"Sum of the above positive numbers are {sum}");
        }
    }
}
