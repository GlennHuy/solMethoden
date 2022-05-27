using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentMuziekEnMethoden
{
    internal class Note
    {
        public void Do()
        {
            Console.Beep(264, 1000);
        }
        public void Re()
        {
            Console.Beep(297, 1000);
        }
        public void Mi()
        {
            Console.Beep(330, 1000);
        }
        public void Fa()
        {
            Console.Beep(352, 1000);

        }
        public void Sol()
        {
            Console.Beep(396, 1000);

        }
        public void La()
        {
            Console.Beep(440, 1000);
        }
        public void Si()
        {
            Console.Beep(495, 1000);
        }
        public void Do2()
        {
            Console.Beep(528, 1000);
        }
    }
}
