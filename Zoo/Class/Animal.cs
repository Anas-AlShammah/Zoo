using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Class
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public Animal(string name,int age)
        {
            Name=name;
            Age=age;
        }
        public abstract void Eat();
        public abstract void Sound();

        public abstract void Sleep();
    }
}
