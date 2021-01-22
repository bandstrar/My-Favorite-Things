using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Pet
    {
        //Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        //Methods
        public void Play()
        {
            if (Type == "Dog")
            {
                Console.WriteLine($"I play fetch with {Name}. What a good dog!");
            }
            else if (Type == "Cat")
            {
                Console.WriteLine($"I point a laser pointer at the wall and {Name} goes crazy for it. What a silly cat!");
            }
            else
            {
                Console.WriteLine($"{Name} does whatever {Type}s do for fun. I watch in amusement.");
            }
        }

        public void Feed()
        {
            Console.WriteLine($"I give {Name} their favorite treat. They're looking good at {Age} years old!");
        }
    }
}
