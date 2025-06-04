namespace CalculatorConsoleApp.Utils
{
    public static class MyCalculator
    {
        public static int Sum(params string[] numbers)
        {
            int sum = 0;

            try
            {
                foreach (var number in numbers)
                {
                    sum += int.Parse(number);
                }

                return sum;
            }
            catch (FormatException e)
            {
                return -1;
            }
        }
    }
}
