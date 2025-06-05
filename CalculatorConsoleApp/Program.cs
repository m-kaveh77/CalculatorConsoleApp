
using CalculatorConsoleApp.Utils;

while (true)
{
    Console.Clear();
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("Welcome to Calculator Console App");
    Console.WriteLine("-----------------------------------------------------------");

    Console.WriteLine();

    Console.WriteLine("------------------- Application options -------------------");
    Console.WriteLine();
    Console.WriteLine("1. Sum");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Power");
    Console.WriteLine("6. Square Root");
    Console.WriteLine("7. Percent");
    Console.WriteLine("8. Factorial");
    Console.WriteLine("9. Exit");
    Console.WriteLine();
    Console.WriteLine("-----------------------------------------------------------");

    Console.Write("Please select your option: ");

    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            {
                Console.Clear();
                Console.WriteLine("Sum of numbers: ");
                Console.WriteLine("-----------------------------------------------------------");

                Console.Write("Separate the numbers with ',': ");
                string? numbers = Console.ReadLine();

                if (string.IsNullOrEmpty(numbers))
                {
                    Console.WriteLine("Numbers cannot is empty.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                string[] splitedNumbers = numbers.Split(",");
                decimal result = MyCalculator.Sum(splitedNumbers);

                if (result == -1)
                    Console.WriteLine("Input format is not valid");
                else
                    Console.WriteLine($"Sum of numbers: {result}");

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                continue;
            }
        case "2":
            {
                Console.Clear();
                Console.WriteLine("Subtract of numbers: ");
                Console.WriteLine("-----------------------------------------------------------");

                Console.Write("Number 1: ");
                string? number1 = Console.ReadLine();

                if (string.IsNullOrEmpty(number1))
                {
                    Console.WriteLine("Number 1 cannot empty.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Number 2: ");
                string? number2 = Console.ReadLine();

                if (string.IsNullOrEmpty(number2))
                {
                    Console.WriteLine("Number 2 cannot empty.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                decimal result = MyCalculator.Subtract(decimal.Parse(number1), decimal.Parse(number2));

                Console.WriteLine($"{number1} - {number2} = {result}");

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                continue;
            }
        case "3":
            {
                Console.Clear();
                Console.WriteLine("Multiply of numbers: ");
                Console.WriteLine("-----------------------------------------------------------");

                Console.Write("Number 1: ");
                string? number1 = Console.ReadLine();

                if (string.IsNullOrEmpty(number1))
                {
                    Console.WriteLine("Number 1 cannot empty.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Number 2: ");
                string? number2 = Console.ReadLine();

                if (string.IsNullOrEmpty(number2))
                {
                    Console.WriteLine("Number 2 cannot empty.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                decimal result = MyCalculator.Multiply(decimal.Parse(number1), decimal.Parse(number2));

                Console.WriteLine($"{number1} * {number2} = {result}");

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                continue;
            }
        case "4":
            {
                Console.Clear();
                Console.WriteLine("Divide of numbers: ");
                Console.WriteLine("-----------------------------------------------------------");

                Console.Write("Number 1: ");
                string? number1 = Console.ReadLine();

                if (string.IsNullOrEmpty(number1))
                {
                    Console.WriteLine("Number 1 cannot empty.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Number 2: ");
                string? number2 = Console.ReadLine();

                if (string.IsNullOrEmpty(number2))
                {
                    Console.WriteLine("Number 2 cannot empty.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                if (number2 == "0")
                {
                    Console.WriteLine("Number 2 cannot have zero value.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                decimal result = MyCalculator.Divide(decimal.Parse(number1), decimal.Parse(number2));

                Console.WriteLine($"{number1} / {number2} = {result}");

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                continue;
            }
        case "5":
            {
                Console.Clear();
                Console.WriteLine("Power of numbers: ");
                Console.WriteLine("-----------------------------------------------------------");

                Console.Write("Number 1: ");
                string? number1 = Console.ReadLine();

                if (string.IsNullOrEmpty(number1))
                {
                    Console.WriteLine("Number 1 cannot empty.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Number 2: ");
                string? number2 = Console.ReadLine();

                if (string.IsNullOrEmpty(number2))
                {
                    Console.WriteLine("Number 2 cannot empty.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                double result = MyCalculator.Power(double.Parse(number1), double.Parse(number2));

                Console.WriteLine($"{number1} ** {number2} = {result}");

                Console.Write("Press any key to continue...");
                Console.ReadKey();
                continue;
            }
        case "6":
            break;

        case "7":
            break;

        case "8":
            break;

        case "9":
            break;

        default:
            {
                Console.WriteLine("Please select valid options");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                continue;
            }
    }
}