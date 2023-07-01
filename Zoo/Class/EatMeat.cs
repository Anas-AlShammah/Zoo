using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public abstract class EatMeat : Ground
    {
        protected EatMeat(string name, int age) : base(name, age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Meat");
        }
    }
}
