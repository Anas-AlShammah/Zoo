using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public abstract class Vegetarian : Ground
    {
        protected Vegetarian(string name, int age) : base(name, age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Vegetarian");
            
        }
    }
}
