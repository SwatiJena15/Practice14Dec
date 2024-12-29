using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assignment1_8
    {
        static void Main()
        {
            int vcount = 0, ccount = 0, others=0;
            Console.WriteLine("Enter String :");
            string st = Console.ReadLine();

            foreach (char c in st)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                        vcount++;
                    else
                        ccount++;
                }
                else
                    others++;
            }
                    Console.WriteLine($"No of vowels is {vcount}");

        }
    }

}

