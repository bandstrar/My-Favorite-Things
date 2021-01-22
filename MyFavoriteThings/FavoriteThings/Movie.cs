using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Movie
    {
        //Properties
        public string Title { get; set; }
        public int MovieLength { get; set; }
        public string Director { get; set; }

        //Methods
        public void Watch()
        {
            Console.WriteLine($"I think {Title} is one of {Director}'s better films.");
        }

        public void Choose()
        {
            if (MovieLength > 150)
            {
                Console.WriteLine("It's too late to start a movie this long, I'll pick something else.");
            }
            else
            {
                Console.WriteLine($"Time to grab a bowl of popcorn and watch some {Title}!");
            }
        }
    }
}
