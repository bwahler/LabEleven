using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEleven
{
    class Program
    {
        static void Main(string[] args)
        {
            ListMovie();
        }

        public static void ListMovie()
        {
            List<Movie> listMovie = new List<Movie>
            {
                new Movie("A Quiet Place", "horror"),
                new Movie("Blazing Saddles", "comedy"),
                new Movie("The Boondock Saints", "thriller"),
                new Movie("Citizen Kane", "drama"),
                new Movie("Death Proof", "thriller"),
                new Movie("Double Indemnity", "film noir"),
                new Movie("Elf", "comedy"),
                new Movie("Gerald's Game", "horror"),
                new Movie("Gladiator", "drama"),
                new Movie("Goodfellas", "drama"),
                new Movie("halloween", "horror"),
                new Movie("Hush", "thriller"),
                new Movie("Leon: The Professional", "thriller"),
                new Movie("Pickup on South Street", "film noir"),
                new Movie("Pontypool", "horror"),
                new Movie("Rear Window", "thriller"),
                new Movie("Spotlight", "drama"),
                new Movie("Step Brothers", "comedy"),
                new Movie("Superbad", "comedy"),
                new Movie("Touch of Evil", "film noir")
            };

            Console.WriteLine("Welcome to the Movie List Application!");
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("What category are you interested in? (Comedy, Drama, Film Noir, Horror)");
                string category = Console.ReadLine().ToLower();
                foreach (Movie film in listMovie)
                {
                    if (film.Category == category)
                    {
                        Console.WriteLine(film.Title);
                    }
                }
                run = Continue();
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to Continue? (y/n)");
            string userContinue = Console.ReadLine().ToLower();
            bool run;
            if(userContinue == "y")
            {
                run = true;
            }
            else if(userContinue == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("That is not a valid entry. Please try again: (y/n)");
                run = Continue();
            }
            return run;
        }
    }
}
