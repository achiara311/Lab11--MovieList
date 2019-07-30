using System;
using System.Collections.Generic;
using System.Text;

namespace MovieList
{
    public class Movie
    {
        #region Fields

        private string title;
        private string category;

        #endregion

        #region Properties

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        #endregion

        #region

        public Movie()
        {

        }

        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        #endregion



        public static int TryParseInput(List<string>connectedCategory)
        {
            try
            {
                string input = Console.ReadLine();//
                int user = int.Parse(input);
                user--;
                return user;
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number.");
                return TryParseInput(connectedCategory);
            }
            catch (OverflowException)
            {
                Console.WriteLine("number way too big.");
                return TryParseInput(connectedCategory);
            }
        }


        public static void DisplayTasks()
        {

            Console.WriteLine("\nWhat category are you interested in?\n");
            Console.WriteLine("Type a number:\n");
        }








    }






    
}
