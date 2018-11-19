using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class day3
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N%2==1)
            {
                Console.WriteLine("Weird");
                Console.ReadLine();
            }
            else if (N % 2 == 0 && N>=2 && N<=5)
            {
                Console.WriteLine("Not Weird");
                Console.ReadLine();

            }
            else if (N % 2 == 0 && N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
                Console.ReadLine();
            }
            else if (N % 2 == 0 && N>20)
            {
                Console.WriteLine("Not Weird");
                Console.ReadLine();
            }
        }
    }
}
