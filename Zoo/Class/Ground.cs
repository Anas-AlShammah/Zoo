using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
     public abstract class Ground :Animal
    {
        protected Ground(string name, int age) : base(name, age)
        {
        }

        public int place { get; set; }

        public virtual int Speedfrom10 { get; set; }

        public virtual bool AttackPepole { get; set; }

        public virtual void NumberOfLeg()
        {
            Console.WriteLine("Have 4 leg");
        }

        public virtual void Move()
        {
            Console.WriteLine(Name + "is running");
        }
    }
}
