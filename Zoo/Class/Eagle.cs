using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public class Eagle : Fly
    {
        public Eagle(string name, int age) : base(name, age)
        {
        }

        public override void Sleep()
        {
            Console.WriteLine("The eagle sleeps on a high branch.");
        }

        public override void Sound()
        {
            Console.WriteLine("The eagle screeches loudly.");
        }
    }
}
