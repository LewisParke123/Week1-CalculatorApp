Console.WriteLine("Type in the first integer number followed by the enter key.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in the second integer number followed by the enter key.");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine("Adding {0} and {1} results in {2}.", firstNumber, secondNumber, result);