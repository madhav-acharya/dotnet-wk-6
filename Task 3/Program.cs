// See https://aka.ms/new-console-template for more information

namespace Task_3;

public class Program
{
    static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (var num in numbers)
        {
            if (condition(num))
            {
                Console.WriteLine(num);
            }
        }
    }
    public static void Main(string[] args)
    {
        int[] numbers = { 4, 7, 12, 15, 8, 22 };

        Console.WriteLine("Even numbers:");
        // Passing a delegate to check for even numbers
        ProcessNumbers(numbers, n => n % 2 == 0);

        Console.WriteLine("\nNumbers greater than 10:");
        // Passing a delegate to check for numbers greater than 10
        ProcessNumbers(numbers, n => n > 10);
    }
}