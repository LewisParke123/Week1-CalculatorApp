CalculatorApp();

void CalculatorApp()
{

    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    Console.WriteLine("Type in the first integer number followed by the enter key.");
    firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Type in the second integer number followed by the enter key.");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose the operation from the following list:");
    Console.WriteLine("1 = addition");
    Console.WriteLine("2 = subtraction");
    Console.WriteLine("3 = multiplication");
    Console.WriteLine("4 = division");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} results in {result}.");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {secondNumber} from {firstNumber} results in {result}.");
    }
    else if (choice == 3)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} results in {result}.");
    }
    else if (choice == 4)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} by {secondNumber} results in {result}.");
    }
    else
    {
        Console.WriteLine("Invalid choice.");
        return;
    }
}