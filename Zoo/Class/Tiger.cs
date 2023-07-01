using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public class Tiger : EatMeat
    {
        public override bool AttackPepole { get; set; }
        public override int Speedfrom10 { get; set; }
        public Tiger(string name, int age) : base(name, age)
        {
            Speedfrom10 = 9;
            AttackPepole= true;
        }

        public override void Sleep()
        {
            Console.WriteLine("The tiger sleeps in its lair.");
        }

        public override void Sound()
        {
            Console.WriteLine("The tiger growls fiercely.");
        }
    }
}
