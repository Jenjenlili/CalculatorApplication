using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate F Formula<F>(F arg1, F arg2);
    internal class CalculatorClass
    {
        public Formula<double> formula;

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        } 
        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }
        
        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
            }
        }
    }
}
