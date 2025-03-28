using System;
using System.Text;

class Program
{
  static int Main(string[] args)
  {
    if (args.Length == 0)
    {
      Console.WriteLine("Please enter a numeric argument.");
      Console.WriteLine("Usage: Factorial <num>");
      return 1;
    }

    int num;
    bool test = int.TryParse(args[0], out num);
    if (!test)
    {
      Console.WriteLine("Please enter a numeric argument.");
      Console.WriteLine("Usage: Factorial <num>");
      return 1;
    }

    long result = Functions.Factorial(num);

    if (result == -1)
      Console.WriteLine("Input must be >= 0 and <= 20.");
    else
      Console.WriteLine($"The Factorial of {num} is {result}.");

    return 0;
  }
}