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
            catc
            {
                return -1;
            }
        }
    }
}
