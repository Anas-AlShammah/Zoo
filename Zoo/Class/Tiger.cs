﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interfaces;

namespace Zoo.Class
{
    public class Tiger : EatMeat , IMammals
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

        public void Play()
        {
            Console.WriteLine("The tiger playfully chases its tail.");
        }

        public void Learn()
        {
            Console.WriteLine("The tiger learns hunting techniques from its mother.");
        }
    }
}
