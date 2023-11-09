using System;

namespace Console_Calculator.Core
{
    class DivideOperation : ICalculatorOperation
    {
        OperationResult ICalculatorOperation.PerformOperation(double num1, double num2)
        {
            if (num2 == 0)
            {
                return new OperationResult()
                {
                    Result = 0,
                    isSuccess = false,
                    ErrorMessage = "Delen door nul is niet toegestaan."
                };
            }
            return new OperationResult()
            {
                Result = num1 / num2,
                isSuccess = true,
                ErrorMessage = ""
            };

        }
    }
}