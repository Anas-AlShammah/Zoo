using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public class Swan : Fly
    {
        public Swan(string name, int age) : base(name, age)
        {
        }

        public override void Sleep()
        {
            Console.WriteLine("The swan sleeps on the water.");
        }

        public override void Sound()
        {
            Console.WriteLine("The swan sings a graceful melody.");
        }
    }
}
