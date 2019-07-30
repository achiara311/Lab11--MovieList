using System;
using System.Collections.Generic;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> classics = new List<Movie>()
            {
                new Movie("The Departed", "drama"),
                new Movie("Frozen", "animated"),
                new Movie("Star Wars", "scifi"),
                new Movie("Hereditary", "horror"),
                new Movie("BladeRunner", "scifi"),
                new Movie("Barton Fink", "drama"),
                new Movie("Up", "animated"),
                new Movie("The Shining", "horror"),
                new Movie("Skyfall","drama"),
                new Movie("The Dark Knight","drama")
            };

            List<string> filmCategory = new List<string> { "drama", "scifi", "horror", "animated" };

            Console.WriteLine("Welcome to the Movie List Applicaton.");
            Console.WriteLine("\nThere ten movies in this list.\n");
            bool repeat = true;
            while (repeat)
            {
                Movie.DisplayTasks();
                for (int i = 0; i < filmCategory.Count; i++) //applies count increment of 
                    //List of genres to Display method
                {
                    Console.WriteLine($"{i + 1}. {filmCategory[i]}");//1.drama 2.scifi etc
                }
                int input = Movie.TryParseInput(filmCategory);//when you make actual input selection
                //from keyboard
                try
                {
                    string title = filmCategory[input];
                    foreach (Movie thing in classics)
                    {
                        if (thing.Category == title) //sauing if the thing you type is equal to string
                                                     //thats equal to the list of filmCategory and its index
                                                     //it will give the title
                        {
                            Console.WriteLine($"{thing.Title}");
                        }
                    }
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number isnt in the range.");
                    repeat = true;//not bringing me back up top.
                }
                

                try
                {
                    
                    string furSure = "";
                    while(furSure!= "y" && furSure !="n")
                    {
                        Console.WriteLine("Would you like to view other categories? y/n");
                        furSure = Console.ReadLine().ToLower();
                    }

                    if (furSure == "y")
                    {
                        repeat = true;
                    }
                    else
                    {
                        Console.WriteLine("Goodbye!");
                        repeat = false;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e.GetType()}: {e.Message}");
                }
                
            }
            
        }
    }
}
