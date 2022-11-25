using Recap_3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal cat = new Animal();
            cat.Name = "Ann";
            Console.WriteLine(cat.Name);

            ICat newBreedOfCat = new Cat();
            //newBreedOfCat.

            ICat cat2 = new Cat(); // αριστερά της ισότητας έχω parent και δεξιά έχω child (polymorphism)
            // line 21 creates a box that from outside "seems" as Animal but holds also the public properties
            // and methods of Cat (if we know how tp access them!!!! (via as keyword))
            cat2.AnimalProperty = 3;
            (cat2 as Cat).MyProperty = 1000;
            Console.WriteLine(cat2.GetType()); // Cat
            Cat cat3 = (Cat)cat2;
            Console.WriteLine(cat3.MyProperty);
            Console.WriteLine(cat2.AnimalProperty);
            Console.WriteLine((cat2 as Cat).MyProperty);

            // can you fix the AnimalProperty error????
        }
    }
}
