using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Tutorial.Day8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String,String> learnEngToSpanish = new Dictionary<string, string>(); 
            learnEngToSpanish.Add("monday", "lunes");
            learnEngToSpanish.Add("tuesday", "martes");
            learnEngToSpanish.Add("Wednesday", "miércoles");
            learnEngToSpanish.Add("Thursday", "jueves");
            learnEngToSpanish.Add("Friday", "viernes");
            learnEngToSpanish.Add("Saturday", "sábado");
            learnEngToSpanish.Add("Sunday", "domingo");
            Console.WriteLine(learnEngToSpanish[("monday")]);
            Console.WriteLine(learnEngToSpanish[("tuesday")]);
            Console.WriteLine(learnEngToSpanish[("Wednesday")]);
            Console.WriteLine(learnEngToSpanish[("Thursday")]);
            Console.WriteLine(learnEngToSpanish[("Friday")]);
            Console.WriteLine(learnEngToSpanish[("Saturday")]);
            Console.WriteLine(learnEngToSpanish[("Sunday")]);

            //print out all the keys
            Console.WriteLine("-------------keys----------");
            Console.Write("[");
            foreach (KeyValuePair<string,string> keyValuePair in learnEngToSpanish)
            {
                Console.Write(keyValuePair.Key+":"+keyValuePair.Value+",");
            }
            Console.Write("]");
            Console.WriteLine();
            Console.WriteLine("the size of hash map "+learnEngToSpanish.Count);
        }
    }
}
