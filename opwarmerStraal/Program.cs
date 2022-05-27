static void BerekenStraal(double diameter)
{ 
    double straal = diameter / 2;
    Console.WriteLine(straal);
}
BerekenStraal(Convert.ToDouble(Console.ReadLine()));