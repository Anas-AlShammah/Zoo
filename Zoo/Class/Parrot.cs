using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public class Parrot : Fly
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
    }
}
