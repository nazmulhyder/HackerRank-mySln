﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    public class Person
    {
        int age=0;
        public Person(int initialAge)
        {
            this.age = initialAge;
            if (age>=0)
            {
                age = initialAge;
            }
            else 
            {
                age = initialAge = 0;
                Console.WriteLine("Age is not valid,setting age to 0.");
                
            }

           
        }

        public void amIOld()
        {
            if (age<13)
            {
                Console.WriteLine("You are young.");
                
            }
            else if (age >= 13 && age<18)
            {
                Console.WriteLine("You are a teenager.");
                
            }
            else 
            {
                Console.WriteLine("You are old.");
                
            }
        }

        public void yearPasses()
        {
            age += 1;
        }
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
              
            }
        }
    
    }
}
