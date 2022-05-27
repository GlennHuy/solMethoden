static void Omtrek(double diameter)
{
    double omtrek = Math.PI * diameter;
    
    double straal = diameter / 2;
    double oppervlakte = Math.PI * Math.Pow(straal, 2);
    
    Console.WriteLine($"de omtrek van {diameter} is {omtrek:F2} en de oppervlakte is {oppervlakte:F2}");
}

Omtrek(Convert.ToDouble(Console.ReadLine()));
