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
            int cats = 35;

            Console.WriteLine("please enter the number of cats you gained: ");
            int mc = (Console.ReadKey());


            int tc = cats + mc;

            Console.WriteLine("your total number of cats is: " + tc);

            Console.ReadKey();
        }
    }
}
