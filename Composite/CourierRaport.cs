using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
     abstract class CourierRaport
     {
          public string Name { get; }

          public CourierRaport(string name)
          {
               Name = name;
          }

          public abstract void Display(int level = 0);
     }
}
