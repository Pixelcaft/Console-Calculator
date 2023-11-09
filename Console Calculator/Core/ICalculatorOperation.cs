namespace Console_Calculator.Core
{
    internal interface ICalculatorOperation
    {
        OperationResult PerformOperation(double num1, double num2);
    }
}