public class Functions
{
  public static long Factorial(int n)
  {
    // Test for invalid input.
    if ((n < 0) || (n > 20))
    {
      return -1;
    }

    // Calculate the factorial iteratively rather than recursively.
    long tempResult = 1;
    for (int i = 1; i <= n; i++)
    {
      tempResult *= i;
    }
    return tempResult;
  }
}