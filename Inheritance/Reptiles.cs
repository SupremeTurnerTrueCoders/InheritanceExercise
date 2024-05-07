using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }

        public string Enviorment { get; set; }

        public string Defense { get; set; }



        public Reptile()

        {

        }
        public Reptile(String name, int age, int legs, bool isColdBlooded, bool hasScales, string Enviorment, string Defense)
        {

            Name = name;
            Age = age;
            Legs = legs;
            
            IsColdBlooded = isColdBlooded;
            HasScales = hasScales;
            Enviorment = Enviorment;
            Defense = Defense;


        }


    }
}
