using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
     class Box : CourierRaport
     {
          private List<CourierRaport> _components = new List<CourierRaport>();
          public Box(string name) : base(name)
          {
          }
          public override void Display(int level = 3)
          {
               string spaces = new string(' ', level);
               Console.WriteLine(spaces + "└ " + Name);
               foreach (var component in _components)
                    component.Display(level + 3); 
          }

          public void AddComponent(CourierRaport component)
          {
               _components.Add(component);
          }

          public void RemoveComponent(CourierRaport component)
          {
               _components.Remove(component);
          }


     }
}
