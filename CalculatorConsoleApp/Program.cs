
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
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                string[] splitedNumbers = numbers.Split(",");
                decimal result = MyCalculator.Sum(splitedNumbers);

                if (result == -1)
                    Console.WriteLine("Input format is not valid");
                else
                    Console.WriteLine($"Sum of numbers: {result}");

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                continue;
            }
        case "2":
            break;

        case "3":
            break;

        case "4":
            break;

        case "5":
            break;

        case "6":
            break;

        case "7":
            break;

        case "8":
            break;

        case "9":
            break;

        default:
            break;
    }
}