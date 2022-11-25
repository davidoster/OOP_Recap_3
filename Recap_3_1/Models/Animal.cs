using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_3_1.Models
{
    internal class Animal : IAnimal
    {
        //public string Name => Name.ToUpper(); // returns the Name // JIT = Just In Time Compile / Debug
        private string _name;
        string IAnimal.Name {
            get => _name.ToUpper();
            //get
            //{
            //    return Name.ToUpper();
            //}
            set => _name = value; 
        }

        int IAnimal.TypeOfAnimal { get; set; }
        public int AnimalProperty { get; set; }
    }
}
