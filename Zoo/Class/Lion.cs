using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public class Lion : EatMeat
    {
        public override bool AttackPepole { get; set; }

        public Lion(string name, int age) : base(name, age)
        {
            AttackPepole=true;
        }

        public override int Speedfrom10 { get ; set ; }

        public override void Sleep()
        {
            Console.WriteLine("The lion sleeps in its den.");
        }

        public override void Sound()
        {
            Console.WriteLine("The lion roars loudly.");
        }
    }
}
