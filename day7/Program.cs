using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arrTemp = Console.ReadLine().Split(' ');
            int[] intArr = Array.ConvertAll(arrTemp, Int32.Parse);
            Array.Reverse(intArr);
            foreach (var traverse in intArr)
            {
                Console.Write(traverse+" ");
            }

            Console.WriteLine();




        }
    }
}
