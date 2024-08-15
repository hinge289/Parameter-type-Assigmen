using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Q7
{
    class Bank
    {
        private int investamount, years, timeCompounds;
        private double rate;
        public Bank(int i, int y, int m = 12, float r = 0.6f)
        {
            investamount = i;
            years = y;
            timeCompounds = m;
            rate = r;
        }
        public double calculate()
        {
            double total=investamount;
            double bacevalue = 1 + rate / timeCompounds;
            int totalcomponding = timeCompounds * years;

            for (int i = 0; i < totalcomponding; i++)
            {
                total *= bacevalue;
            }


            return total;
                
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anual intrest rate 6%");
            Console.WriteLine("What whould like To invest Per Month");
            int peramount=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter yeras How Many time ");
            int year=int.Parse(Console.ReadLine());

            Bank obj = new Bank(i:peramount,y:year);
            double total=obj.calculate();
            Console.WriteLine($"Total {total} Amount you get after {year} years ");

        }
    }
}
