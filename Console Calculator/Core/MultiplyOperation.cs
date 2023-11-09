namespace Console_Calculator.Core   
{
    class MultiplyOperation : ICalculatorOperation
    {
        OperationResult ICalculatorOperation.PerformOperation(double num1, double num2)
        {
            return new OperationResult()
            {
                Result = num1 * num2,
                isSuccess = true,
                ErrorMessage = ""
            };
        }
    }
}