using assignmentMuziekEnMethoden;

void Do(int duration=1000, int octave=1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Do");
    Console.ResetColor();
    Console.Beep((253*octave), duration);
}
void Re(int duration=1000, int octave = 1)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Re");
    Console.ResetColor();
    Console.Beep(297*octave, duration);
}
void Mi(int duration = 1000, int octave = 1)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Mi");
    Console.ResetColor();
    Console.Beep(330*octave, duration);
}
void Fa(int duration = 1000, int octave = 1)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Fa");
    Console.ResetColor();
    Console.Beep(352*octave, duration);

}
void Sol(int duration=1000, int octave = 1)
{ 
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Sol");
    Console.ResetColor();

    Console.Beep(396*octave, duration);

}
void La(int duration=1000, int octave = 1)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("La");
    Console.ResetColor();
    Console.Beep(440*octave, duration);
}
void Si(int duration=1000, int octave = 1)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("Si");
    Console.ResetColor();
    Console.Beep(495*octave, duration);
}
void Do2(int duration=1000, int octave = 1)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Do");
    Console.ResetColor();
    Console.Beep(528*octave, duration);
}

static void ChooseSong();
{

}

Re(250);
Sol(250);
La(250);
Si(250);
Si(250);
Si(250);
La(250);
Si(250);
Sol(250);
Sol(250);


Sol(250);
La(250);
Si(250);
Do(250);
Mi(250);
Mi(250);
Re(250);
Do(250);
Si(250);


Do(500, 2);
Re(500, 2);
Mi(500, 2);
Fa(500, 2);
Sol(500, 2);
La(500, 2);
Si(500, 2);
Do2(500, 2);