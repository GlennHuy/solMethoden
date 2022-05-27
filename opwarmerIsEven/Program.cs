static void IsEven(double x)
{
    if (x%2 == 0)
    {
        bool evenoneven = true;
        Console.WriteLine($"{evenoneven}");
    }
    else if (x%2 != 0)
    {
        bool evenoneven = false;
        Console.WriteLine($"{evenoneven}");
    }
}
IsEven(Convert.ToDouble(Console.ReadLine()));