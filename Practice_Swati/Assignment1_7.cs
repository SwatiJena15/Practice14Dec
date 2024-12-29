using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Assignment1_7
    {
        static void Main()

        {
            Console.WriteLine("Name split into array :");
            string name = "Swati, Anusha, Aru";
            
            string[] name1 =name.Split(", ");

            foreach (string s in name1)
                Console.WriteLine(s);
            

        }

         
    }
}
