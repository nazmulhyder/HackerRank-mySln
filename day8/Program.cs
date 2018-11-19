using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, int>();
            var n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                /*
                 * number[0] = a
                 * number[1] = b
                 * number[2] = c
                 *
                 */
                string[] nameCnumber = Console.ReadLine().Split(' ');
                string name = nameCnumber[0];
                int number = Int32.Parse(nameCnumber[1]);
                phoneBook.Add(name,number);

            }



            while (true)
            {
                string name = Console.ReadLine();
                if (phoneBook.ContainsKey(name))
                {
                    Console.WriteLine(name + "=" + phoneBook[name]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

            

            //phoneBook.Add("Sam",0183);
            //phoneBook.Add("Sab",0173);
            //phoneBook.Add("Me",0144);
            //foreach (KeyValuePair<string,int> keyValuePair in phoneBook)
            //{
            //    Console.WriteLine(keyValuePair.Key+" "+keyValuePair.Value);
            //}
            //Console.WriteLine("count =>"+phoneBook.Count);
            //Console.WriteLine("what you want to search ");
            //var searchPhoneName = Console.ReadLine();

            //if (phoneBook.ContainsKey(searchPhoneName))
            //{
            //    Console.WriteLine("found");
            //}
            //else
            //{
            //    Console.WriteLine("not found!");
            //}






        }
    }
}

