using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Array
{
    public class Program
    {
        public static void CustomArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                int item = array[i];
                Console.Write(item);
                if (i < array.Length-1)
                {
                    Console.Write(",");
                }
               
            }
            Console.WriteLine("]");
        }
        static void Main(string[] args)
        {
            //custom array
            int[] array1 = new int[5];
            array1[0] = 5;
            array1[1] = 4;
            array1[2] = 6;
            array1[3] = 7;
            array1[4] = 8;
            CustomArray(array1);
        }
    }
}
