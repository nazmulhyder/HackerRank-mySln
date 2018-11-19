using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                str1 = Console.ReadLine();
                for (int j = 0; j < str1.Length; j++)
                {
                    if (j%2==0)
                    {
                        Console.Write(str1.ElementAt(j));
                    }
                }
                Console.Write(" ");
                for (int j = 0; j < str1.Length; j++)
                {
                    if (j % 2 == 1)
                    {
                        Console.Write(str1.ElementAt(j));
                    }
                }
                Console.WriteLine();
            }
            

        }
    }
}
