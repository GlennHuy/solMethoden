using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentMuziekEnMethoden
{
    public class Playlist
    {
        Note instance;

        public Playlist()
        {
            instance = new Note();
        }


        private void Log(string input)
        {
            Console.WriteLine($"playing song: {input}");
        }

        public void DoReMi()
        {
            Log("Do Re Mi");
            instance.Do();
            instance.Re();
            instance.Mi();
            instance.Fa();
            instance.Sol();
            instance.La();
            instance.Si();
            instance.Do2();
        }



        public void YouAreMySunshine()
        {
            Log("You Are My Sunshine");
            instance.Re();
            instance.Sol();
            instance.La();
            instance.Si();
            instance.Si();
            instance.Si();
            instance.La();
            instance.Si();
            instance.Sol();
            instance.Sol();


            instance.Sol();
            instance.La();
            instance.Si();
            instance.Do();
            instance.Mi();
            instance.Mi();
            instance.Re();
            instance.Do();
            instance.Si();
        }

    }
}
