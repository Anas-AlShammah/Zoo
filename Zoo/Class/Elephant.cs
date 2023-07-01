using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public class Elephant : Vegetarian
    {
        public override int Speedfrom10 { get; set; }
        public Elephant(string name, int age) : base(name, age)
        {
        }

        public override void Sleep()
        {
            Console.WriteLine("The elephant sleeps standing up.");
        }

        public override void Sound()
        {
            Console.WriteLine("The elephant trumpets loudly.");
        }
    }
}
