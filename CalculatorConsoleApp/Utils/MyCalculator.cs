namespace CalculatorConsoleApp.Utils
{
    public static class MyCalculator
    {
        public static decimal Sum(params string[] numbers)
        {
            decimal sum = 0;

            try
            {
                foreach (var number in numbers)
                {
                    sum += decimal.Parse(number);
                }

                return sum;
            }
            catch
            {
                return -1;
            }
        }

        public static decimal Subtract(decimal number1, decimal number2)
        {
            return number1 - number2;
        }

        public static decimal Multiply(decimal number1, decimal number2)
        {
            return number1 * number2;
        }

        public static decimal Divide(decimal number1, decimal number2)
        {
            return number1 / number2;
        }

        public static double Power(double number1, double number2)
        {
            return Math.Pow(number1, number2);
        }

        public static double SquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        public static decimal Percent(decimal number1, decimal number2)
        {
            return (number1 / number2) * 100;
        }

        public static int Factorial(int number)
        {
            if (number < 2)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}
