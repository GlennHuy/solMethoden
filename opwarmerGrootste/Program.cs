static void Grootste(double x, double y)
{
    if (x < y)
    {
        Console.WriteLine($"{y}is groter dan {x}");        
    }
    else if (x > y)
    {
        Console.WriteLine($"{x} is groter dan {y}");        
    }
    else
    {
        Console.WriteLine("alletwee de cijfers zijn even groot");
    }
}
Grootste(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));