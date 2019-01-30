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
            Movies();
        }

        public static void Movies()
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            bool run = true;
            listMovie();
            while (run == true)
            {
                Console.WriteLine("What category are you interested in?");
                string category = Console.ReadLine().ToLower();
                foreach (Movie film in listMovies)
                {
                    if (film.MovieCategory == category)
                    {
                        Console.WriteLine(film.MovieTitle);
                    }
                }
                run = Continue();
            }
        }

        public static List<Movie> listMovies = new List<Movie>();
        public static void listMovie()
        {

            Movie aQuietPlace = new Movie("A Quiet Place", "horror");
            Movie blazingSaddles = new Movie("Blazing Saddles", "comedy");
            Movie theBoondockSaints = new Movie("The Boondock Saints", "thriller");
            Movie citizenKane = new Movie("Citizen Kane", "drama");
            Movie deathProof = new Movie("Death Proof", "thriller");
            Movie doubleIndemnity = new Movie("Double Indemnity", "film noir");
            Movie elf = new Movie("Elf", "comedy");
            Movie geraldsGame = new Movie("Gerald's Game", "horror");
            Movie gladiator = new Movie("Gladiator", "drama");
            Movie goodfellas = new Movie("Goodfellas", "drama");
            Movie halloween = new Movie("halloween", "horror");
            Movie hush = new Movie("Hush", "thriller");
            Movie leon = new Movie("Leon: The Professional", "thriller");
            Movie pickupOnSouthStreet = new Movie("Pickup on South Street", "film noir");
            Movie pontypool = new Movie("Pontypool", "horror");
            Movie rearWindow = new Movie("Rear Window", "thriller");
            Movie spotlight = new Movie("Spotlight", "drama");
            Movie stepBrothers = new Movie("Step Brothers", "comedy");
            Movie superbad = new Movie("Superbad", "comedy");
            Movie touchOfEvil = new Movie("Touch of Evil", "film noir");


            listMovies.Add(aQuietPlace);
            listMovies.Add(blazingSaddles);
            listMovies.Add(theBoondockSaints);
            listMovies.Add(citizenKane);
            listMovies.Add(deathProof);
            listMovies.Add(doubleIndemnity);
            listMovies.Add(elf);
            listMovies.Add(geraldsGame);
            listMovies.Add(gladiator);
            listMovies.Add(goodfellas);
            listMovies.Add(halloween);
            listMovies.Add(hush);
            listMovies.Add(leon);
            listMovies.Add(pickupOnSouthStreet);
            listMovies.Add(pontypool);
            listMovies.Add(rearWindow);
            listMovies.Add(spotlight);
            listMovies.Add(stepBrothers);
            listMovies.Add(superbad);
            listMovies.Add(touchOfEvil);        
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
