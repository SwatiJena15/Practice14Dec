using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assignment1_5
    {
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("Enter 10 numbers");

            for (int i = 0; i < 10; i++)
            {
                int num = Int16.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine($"Sum of above 10 numbers is {sum}");
        }
    }
}
