using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public class Panda : Vegetarian
    {
        public override int Speedfrom10 { get; set; }
        public Panda(string name, int age) : base(name, age)
        {
        }

        public override void Sleep()
        {
            Console.WriteLine("The panda sleeps in a tree or on the ground.");
        }

        public override void Sound()
        {
            Console.WriteLine("The panda makes a gentle grunting sound.");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} is climbing trees.");
        }
    }
}
