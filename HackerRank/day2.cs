using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class day2
    {
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            double tip = meal_cost * tip_percent/100;
            double tax = meal_cost * tax_percent/100;
            meal_cost = meal_cost+tip + tax;
            Console.WriteLine(Math.Round(meal_cost));
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }

    }
}
