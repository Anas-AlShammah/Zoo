using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.Class
{
    public class Eagle : Fly ,IBirds,IMammals
    {
        public Eagle(string name, int age) : base(name, age)
        {
        }

        public void BestPlaceToLives()
        {
            Console.WriteLine($"{Name} prefers to live in high mountain areas.");
        }

        public bool Eatfish()
        {
            Console.WriteLine($"{Name} eats fish.");
            return true;
        }


        public void Learn()
        {
            Console.WriteLine("The eagle learns flying techniques from its parents.");
        }

        public void Play()
        {
            Console.WriteLine("The eagle plays in the air, soaring and gliding.");
        }

        public override void Sleep()
        {
            Console.WriteLine("The eagle sleeps on a high branch.");
        }

        public override void Sound()
        {
            Console.WriteLine("The eagle screeches loudly.");
        }
    }
}
