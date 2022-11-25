using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Recap_3_1.Models
{
    internal class Cat : Animal, ICat
    {
        public int TypeOfCat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MyProperty { get; set; }
    }
}
