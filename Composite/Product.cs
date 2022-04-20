using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
     class Product : CourierRaport
     {
          public Product(string name) : base(name)
          {

          }

          public override void Display(int level = 3)
          {
               string spaces = new string(' ', level);
               Console.WriteLine(spaces + "└ " + Name);
          }
     }
}
