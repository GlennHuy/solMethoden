static void EvenNum(double x)
{
    for (int i = 0; i < x; i++)
    {
        if (i % 2 == 0)
        {
            continue;
        }
        else if (i % 2 != 0)
        {
            Console.WriteLine($"{i}");
        }
    
    }
    Console.WriteLine(x);
}
Console.WriteLine("Geef een getal in.");
EvenNum(Convert.ToDouble(Console.ReadLine()));