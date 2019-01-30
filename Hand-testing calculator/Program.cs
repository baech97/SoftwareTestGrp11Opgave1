using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Hand_testing_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Add: " + calc.Add(2, 2));
            Console.WriteLine("Subtract: " + calc.Subtract(8,2));
            Console.WriteLine("Multiply: " + calc.Multiply(7, 3));
            Console.WriteLine("Power: " + calc.Power(10, 2));
            Console.ReadKey();


        }
    }
}
