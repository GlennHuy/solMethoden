static double Tel1Op(double x, double y)
{
    double som = x + y;
    return som;
}

static double TrekAf(double x, double y)
{
    double som = x - y;
    return som;
}

static double Vermenigvuldig(double x, double y)
{
    double som = x * y;
    return som;
}

static double Deel(double x, double y)
{
    double som = x / y;
    return som;
}

static double Input()
{
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}

char bewerking = ' ';
double som = 0;

while (bewerking != '=')
{
    if (som == 0)
    {
        double input1 = Input();
        bewerking = Convert.ToChar(Console.ReadLine());
        double input2 = Input();
        switch (bewerking)
        {
            case '+':
                som = Tel1Op(input1, input2);
                break;
            case '-':
                som = TrekAf(input1, input2);
                break;
            case '*':
                som = Vermenigvuldig(input1, input2);
                break;
            case '/':
                som = Deel(input1, input2);
                break;
            default:
                Console.WriteLine("Verkeerde bewerking ingegeven");
                break;
        }
    }
    else
    {
        double input1 = som;
        bewerking = Convert.ToChar(Console.ReadLine());
        double input2 = Input();
        switch (bewerking)
        {
            case '+':
                som = Tel1Op(input1, input2);
                break;
            case '-':
                som = TrekAf(input1, input2);
                break;
            case '*':
                som = Vermenigvuldig(input1, input2);
                break;
            case '/':
                som = Deel(input1, input2);
                break;
            default:
                Console.WriteLine("Verkeerde bewerking ingegeven");
                break;
        }
    }
    Console.WriteLine($"{som:F2}");
}




