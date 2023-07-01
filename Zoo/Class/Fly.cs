using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public abstract class Fly : Animal
    {
        protected Fly(string name, int age) : base(name, age)
        {
        }
        public virtual int MaxHight { get; set; }
        public virtual int Cost { get; set; } = 50;
        public override void Eat()
        {
            Console.WriteLine("Hant");
        }
    }
}
