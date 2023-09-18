using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter side A : ");
            double sa = Convert.ToDouble(Console.ReadLine());
            // takes input from user for the first side

            Console.WriteLine("enter side A : ");
            double sb = Convert.ToDouble(Console.ReadLine());
            // takes input from user for the second side

            double result = Math.Sqrt((sa * sa) + (sb * sb));
            // calculates the hypotanuse

            Console.WriteLine("The hypotenuse for the right angle triangle is: " + result);
            //outputs result to user

            Console.ReadKey();
        }
        }
    }
}
