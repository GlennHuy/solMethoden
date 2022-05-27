//static void MyIntro(string naam, int leeftijd, string adres)
{
    //Console.WriteLine($"Ik ben {naam}, ik ben {leeftijd} jaar oud en woon in de {adres}.");
}
//MyIntro("Glenn", 28, "Aardstraat 2");

static double Input()
{
    Console.WriteLine("Geef een getal in.");
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}
static double Output(double x)
{
    double output = x;
    Console.WriteLine(x);
}



static double Vergelijking(double x, double y)
{
    if (x > y)
    {
        double grootste = x;
        return grootste;
    }
    else
    {
        double grootste = y;
        return grootste;
    }
    
}
Input();

Output();