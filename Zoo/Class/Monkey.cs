using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public class Monkey : Vegetarian
    {
        public override int Speedfrom10 { get; set; }
        public Monkey(string name, int age) : base(name, age)
        {
            Speedfrom10 = 7;
        }

        public override void Sleep()
        {
            Console.WriteLine("The monkey sleeps on a tree branch.");
        }

        public override void Sound()
        {
            Console.WriteLine("The monkey chatters and screeches.");
        }
        public override void NumberOfLeg()
        {
            Console.WriteLine("2 leg and 2 hand");
        }
    }
}
