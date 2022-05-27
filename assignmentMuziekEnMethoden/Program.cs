using assignmentMuziekEnMethoden;

void Do(int hertz, int duration)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Do");
    Console.ResetColor();
    Console.Beep(hertz, duration);
}
void Re()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Re");
    Console.ResetColor();
    Console.Beep(297, 1000);
}
void Mi()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Mi");
    Console.ResetColor();
    Console.Beep(330, 1000);
}
void Fa()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Fa");
    Console.ResetColor();
    Console.Beep(352, 1000);

}
void Sol()
{ 
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sol");
    Console.ResetColor();

    Console.Beep(396, 1000);

}
void La()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("La");
    Console.ResetColor();
    Console.Beep(440, 1000);
}
void Si()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Si");
    Console.ResetColor();
    Console.Beep(495, 1000);
}
void Do2()
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Do");
    Console.ResetColor();
    Console.Beep(528, 1000);
}

Do(253, 500);
Re();
Mi();
Fa();
Sol();
La();
Si();
Do2();