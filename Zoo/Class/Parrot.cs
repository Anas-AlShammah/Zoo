using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.Class
{
    public class Parrot : Fly , IBirds
    {
        public Parrot(string name, int age) : base(name, age)
        {
        }

        public override void Sleep()
        {
            Console.WriteLine("The parrot sleeps on its perch.");
        }

        public override void Sound()
        {
            Console.WriteLine("The parrot imitates human speech.");
        }


        public void BestPlaceToLives()
        {
            Console.WriteLine("The parrot lives in tropical rainforests.");
        }

      

        public bool Eatfish()
        {
            Console.WriteLine("The parrot does not eat fish.");
            return false;
        }
    }
}
