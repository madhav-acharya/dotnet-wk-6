namespace Task_1;

public class Rectangle
{
    private double length;
    private double breadth;

    public double Length
    {
        get => length; 
        set => length = value; 
    }
    
    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }

    public double GetArea() =>  length * breadth;

    public double GetPerimeter() => length * 2 + breadth * 2;

    public string ShowDetails() => $"Length: {length} breadth: {breadth}";
}