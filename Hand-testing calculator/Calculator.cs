using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand_testing_calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public double Subtract(double a, double b)
        {
            double difference = a - b;
            return difference;
        }

        public double Multiply(double a, double b)
        {
            double product = a * b;
            return product;
        }

        public double Power(double x, double exp)
        {
            double x_raised = Math.Pow(x, exp);
            return x_raised;

        }
    }
}
