using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentMuziekEnMethoden
{
    internal class Note
    {
        public  void Do(int duration = 1000, int octave = 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Do");
            Console.ResetColor();
            Console.Beep((253 * octave), duration);
        }
        public  void Re(int duration = 1000, int octave = 1)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Re");
            Console.ResetColor();
            Console.Beep(297 * octave, duration);
        }
        public  void Mi(int duration = 1000, int octave = 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mi");
            Console.ResetColor();
            Console.Beep(330 * octave, duration);
        }
        public  void Fa(int duration = 1000, int octave = 1)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Fa");
            Console.ResetColor();
            Console.Beep(352 * octave, duration);

        }
        public  void Sol(int duration = 1000, int octave = 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sol");
            Console.ResetColor();
            Console.Beep(396 * octave, duration);

        }
        public  void La(int duration = 1000, int octave = 1)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("La");
            Console.ResetColor();
            Console.Beep(440 * octave, duration);
        }
        public  void Si(int duration = 1000, int octave = 1)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Si");
            Console.ResetColor();
            Console.Beep(495 * octave, duration);
        }
        public  void Do2(int duration = 1000, int octave = 1)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Do");
            Console.ResetColor();
            Console.Beep(528 * octave, duration);
        }
    }
}
