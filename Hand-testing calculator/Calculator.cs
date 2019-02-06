using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand_testing_calculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            double sum = a + b;
            Accumulator = sum; 
            return sum;
        }

        public double Subtract(double a, double b)
        {
            double difference = a - b;
            Accumulator = difference;
            return difference;
        }

        public double Multiply(double a, double b)
        {
            double product = a * b;
            Accumulator = product;
            return product;
        }

        public double Power(double x, double exp)
        {
            double x_raised = Math.Pow(x, exp);
            Accumulator = x_raised;
            return x_raised;
        }

        public double Divide(double a, double b)
        {

            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            
            double resultat = a / b;
            Accumulator = resultat;
            return resultat;
        }

        public void Clear()
        {
            Accumulator = 0;
        }

        //test
    }
}
