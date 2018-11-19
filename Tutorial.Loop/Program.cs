using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Loop
{
    class Program
    {
        
        public static void Loop()
        {
            int x = 0;
            while (x<5)
            {
               Console.WriteLine(x);
               x++;
            }
            Console.WriteLine("----------------");
        }

        public static void doWhile()
        {
            int x=0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x<5);
            Console.WriteLine("----------------");
        }

        public static void forLoop()
        {
           //for loop and nested loop 
            for (int x = 0; x < 5; x++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("("+x+","+i+")");
                }
            }
        }
        static void Main(string[] args)
        {
            Loop();
            doWhile();
            forLoop();
        }
    }
}
