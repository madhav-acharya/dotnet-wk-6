// See https://aka.ms/new-console-template for more information

namespace Task_1;
class Program
{
    static void Main(string[] args) 
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Length = 5;
        rectangle.Breadth = 3;
        Console.WriteLine(rectangle.ShowDetails());
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(rectangle.GetPerimeter());
    }
}