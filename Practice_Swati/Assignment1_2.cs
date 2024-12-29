using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{ 
    internal class Assignment1_2
    {
        
        static void Main()
        {
            int num = 5;
            Console.WriteLine("Displaying Table 5\n");
            for (int i = 1; i <= 10; i++)

            {
                int multiply = num * i;
               
                Console.WriteLine($"{num}*{i}={multiply}");
            }
        }
    }
}
