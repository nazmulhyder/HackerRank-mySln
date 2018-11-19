using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());
            int result, i;
            for (i = 1; i <= 10; i++)
            {
                result = n * i;
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);

            }
            Console.ReadLine();
        }
    }
}
