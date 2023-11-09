using System;

namespace Console_Calculator.Core
{
    internal class DecimalValidator
    {

        public static bool IsValidDecimal(double number)
        {
            {
                int decimalPlaces = BitConverter.GetBytes(decimal.GetBits((decimal)number)[3])[2];
                return decimalPlaces <= 2;
            }
        }
    }
}
