using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Book
    {
        //Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int PagesRemaining { get; set; }

        //Methods
        public void Read()
        {
            if ( PagesRemaining < 30 )
            {
                Console.WriteLine($"I finished {Title}. What a great book! I love {Author}!");
            }
            else
            {
                Console.WriteLine($"I make a good dent in {Title}. It's so hard to put down, but I'm very sleepy.");
            }
        }
        public void Select()
        {
            Console.WriteLine($"I think I'll read {Title}. I've enjoyed the books I've read by {Author}");
        }
    }
}
