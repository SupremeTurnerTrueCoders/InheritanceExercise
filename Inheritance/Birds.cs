using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public int Wings { get; set; }

        public string Type { get; set; }

        public bool IsWarmBlooded { get; set; }

        public bool HasFeathers { get; set; }



        public Bird()
        {


        }

        public Bird(string name, int age, int legs,bool isWarmBlooded, bool hasFeathers, int wings, string type)
        {
            Name = name;
            Age = age;
            Legs = legs;
            Type = type;
            IsWarmBlooded = isWarmBlooded;
            HasFeathers = hasFeathers;
            Wings = wings;
           


        }
    }
}


