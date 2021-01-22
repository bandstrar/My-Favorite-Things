using System;
using MyFavoriteThings.FavoriteThings;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Books
            var book1 = new Book
            {
                Title = "Kings of the Wyld",
                Author = "Nicholas Eames",
                PagesRemaining = 200
            };
            var book2 = new Book
            {
                Title = "Prelude to Foundation",
                Author = "Isaac Asimov",
                PagesRemaining = 20
            };

            book1.Select();
            book2.Read();

            //Food
            var shrimp = new Food
            {
                Type = "Shrimp Cocktail",
                Calories = 300
            };
            var iceCream = new Food
            {
                Type = "Ice Cream",
                Calories = 800
            };

            shrimp.Eat();
            iceCream.Cook();

            //Movie
            var movie1 = new Movie
            {
                Title = "There Will Be Blood",
                MovieLength = 158,
                Director = "Paul Thomas Anderson"
            };
            var movie2 = new Movie
            {
                Title = "Monty Python and the Holy Grail",
                MovieLength = 91,
                Director = "Terry Gilliam"
            };

            movie1.Watch();
            movie2.Choose();

            //Pet
            var clark = new Pet
            {
                Name = "Clark",
                Age = 10,
                Type = "Dog"
            };
            var tweet = new Pet
            {
                Name = "Tweet",
                Age = 4,
                Type = "Dog"
            };

            clark.Feed();
            tweet.Play();
        }
    }
}
