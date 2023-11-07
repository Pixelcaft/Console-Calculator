using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal interface ICalculatorOperation
    {
        double PerformOperation(double num1, double num2);
    }

    class AddOperation : ICalculatorOperation
    {
        public double PerformOperation(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    class SubtractOperation : ICalculatorOperation
    {
        public double PerformOperation(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    class MultiplyOperation : ICalculatorOperation
    {
        public double PerformOperation(double num1, double num2)
        {
            return num1 * num2;
        }
    }

    class DivideOperation : ICalculatorOperation
    {
        public double PerformOperation(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Delen door nul is niet toegestaan.");
                return double.NaN;
            }
            return num1 / num2;
        }
    }
}