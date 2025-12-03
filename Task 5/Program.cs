// See https://aka.ms/new-console-template for more information
namespace Task_5;
public class Program
{
    static void Main()
    {
   

        var cashierSales = new List<CashierSales>
            {
                new CashierSales { CashierName = "Ram", SalesAmount = 5000 },
                new CashierSales { CashierName = "Sita", SalesAmount = 7500 },
                new CashierSales { CashierName = "Hari", SalesAmount = 6200 },
                new CashierSales { CashierName = "Gita", SalesAmount = 4800 }
            };

        int totalCashiers = cashierSales.Count();
        double totalSales = cashierSales.Sum(c => c.SalesAmount);
        double highestSale = cashierSales.Max(c => c.SalesAmount);
        double lowestSale = cashierSales.Min(c => c.SalesAmount);
        double averageSale = cashierSales.Average(c => c.SalesAmount);

        Console.WriteLine("==== Aggregation Result ====");
        Console.WriteLine($"Total Cashiers: {totalCashiers}");
        Console.WriteLine($"Total Sales: Rs. {totalSales}");
        Console.WriteLine($"Highest Sale: Rs. {highestSale}");
        Console.WriteLine($"Lowest Sale: Rs. {lowestSale}");
        Console.WriteLine($"Average Sale: Rs. {averageSale}");





        var applicants = new List<Applicant>
            {
                new Applicant { Name = "Aarav", Age = 21 },
                new Applicant { Name = "Riya", Age = 17 },
                new Applicant { Name = "Kamal", Age = 19 },
                new Applicant { Name = "Puja", Age = 20 }
            };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("\n==== Quantifier Result ====");
        Console.WriteLine($"Any applicant under 18? {anyUnder18}");
        Console.WriteLine($"Are all applicants above 16? {allAbove16}");



        var songs = new List<Music>
            {
                new Music { Title = "Intro", DurationSeconds = 120 },
                new Music { Title = "Soft Melody", DurationSeconds = 240 },
                new Music { Title = "Rock Anthem", DurationSeconds = 300 },
                new Music { Title = "Epic Finale", DurationSeconds = 500 }
            };

        var firstSong = songs.First();
        var lastSong = songs.Last();

        var firstAbove4Min = songs.First(s => s.DurationSeconds > 240);

        var firstAbove10Min = songs.FirstOrDefault(s => s.DurationSeconds > 600);

        Console.WriteLine("\n==== Element Operators Result ====");
        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First Song > 4 min: {firstAbove4Min.Title}");

        if (firstAbove10Min == null)
            Console.WriteLine("No song found longer than 10 minutes (Safe Result: null)");
        else
            Console.WriteLine($"Song longer than 10 minutes: {firstAbove10Min.Title}");
    }
}