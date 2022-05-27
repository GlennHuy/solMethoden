using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentFilmDefault
{
    internal class Film
    {
        public string Title { get; set; }
        public int RunTime { get; set; }

        public Genres Genre { get; set; }
        public bool Geschikt { get; set; }

        public void PrintFilm()
        {
            Console.WriteLine($"{Title} ({RunTime}, {Genre})");
        }

        public Film (string title, int runtime = 90, Genres genre = Genres.Actie)
        {
            Title = title;
            Genre = genre;
            RunTime = runtime;
            
        }
    }
}
