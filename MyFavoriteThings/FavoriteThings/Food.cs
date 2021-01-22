using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Food
    {
        //Properties
        public string Type { get; set; }
        public int Calories { get; set; }

        //Methods
        public void Eat()
        {
            if (Calories > 750)
            {
                Console.WriteLine($"I need to take a nap. No more {Type} for me.");
            }
            else
            {
                Console.WriteLine($"I feel great! I'd love another plate of {Type}!");
            }
        }

        public void Cook()
        {
            Console.WriteLine($"I make a heaping helping of {Type}");
        }
    }
}
