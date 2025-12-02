// See https://aka.ms/new-console-template for more information

namespace Task_2;
public delegate int Calculate(int a, int b);

public delegate double DiscountStrategy(double price);

public class Program
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;

    public static double FestiveDiscount(double price) => price * 0.2;
    public static double SeasonalDiscount(double price) => price * 0.1;
    public static double NoDiscount(double price) => 0;

    public static double lambdaprice = 101;
    
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) => originalPrice - strategy(originalPrice);

    public static void Main()
    {
        Calculate add = Add;
        Calculate subtract = Subtract;
        
        Console.WriteLine($"The sum is{add(10, 20)}");
        Console.WriteLine($"The  difference is{subtract(10, 20)}");
        
        DiscountStrategy seasonal = SeasonalDiscount;
        Console.WriteLine($"The seasonal discount is{seasonal(100)}");
        DiscountStrategy festive = FestiveDiscount;
        Console.WriteLine($"The festive discount is{festive(100)}");
        DiscountStrategy noDiscount = NoDiscount;
        Console.WriteLine($"The no-discount discount is{noDiscount(100)}");
        
        
        Console.WriteLine("final price after seasonal discount"+ CalculateFinalPrice(100, seasonal));
        Console.WriteLine("final price after festive discount"+ CalculateFinalPrice(100, festive));
        Console.WriteLine("final price after no discount"+ CalculateFinalPrice(100, noDiscount));
        
        Console.WriteLine("final price after 30% dicount with lamdba"+ CalculateFinalPrice(lambdaprice, (lambdaprice)=> lambdaprice * 0.3));
        
    }
}

