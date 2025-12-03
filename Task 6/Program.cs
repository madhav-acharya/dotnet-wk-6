// See https://aka.ms/new-console-template for more information
namespace Task_6;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Booking> bookings = new List<Booking>
        {
            new Booking { CustomerName="Rahul", Destination="Pokhara", Price=8000, DurationInDay=3, IsInternational=false },
            new Booking { CustomerName="Sita",  Destination="Bangkok", Price=25000, DurationInDay=5, IsInternational=true },
            new Booking { CustomerName="Hari",  Destination="Dubai", Price=40000, DurationInDay=6, IsInternational=true },
            new Booking { CustomerName="Mira", Destination="Chitwan", Price=12000, DurationInDay=5, IsInternational=false },
            new Booking { CustomerName="John", Destination="Singapore", Price=35000, DurationInDay=4, IsInternational=true },
            new Booking { CustomerName="Anu", Destination="Lumbini", Price=15000, DurationInDay=7, IsInternational=false }
        };

        var filtered = bookings
            .Where(b => b.Price > 10000 && b.DurationInDay > 4);

        var projected = filtered
            .Select(b =>
            {
                b.Category = b.IsInternational ? "International" : "Domestic";
                return b;
            });

        var sorted = projected
            .OrderBy(b => b.Category)
            .ThenBy(b => b.Price);

        Console.WriteLine("\n=== FINAL TOUR SUMMARY REPORT ===\n");

        foreach (var b in sorted)
        {
            Console.WriteLine(
                $"Name: {b.CustomerName}\n" +
                $"Destination: {b.Destination}\n" +
                $"Category: {b.Category}\n" +
                $"Price: Rs. {b.Price}\n" +
                "----------------------------------"
            );
        }
    }
}
