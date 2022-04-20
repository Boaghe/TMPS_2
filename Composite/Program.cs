using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
     class Program
     {
          static void Main(string[] args)
          {
               Box Plane = new Box("Plane");
               Box EU = new Box("EU");
               Box USA = new Box("USA");
               Plane.AddComponent(EU);
               Plane.AddComponent(USA);

               Product part1 = new Product("SocialHelp.mp3");
               Product part2 = new Product("Food.mp3");
               Product part3 = new Product("Drugs.mp3");
               USA.AddComponent(part1);
               USA.AddComponent(part2);
               USA.AddComponent(part3);

               Product part1u = new Product("Ammunition.mp3");
               Product part2u = new Product("Weapons.mp3");
               Product part3u = new Product("Shells.mp3");
               EU.AddComponent(part1u);
               EU.AddComponent(part2u);
               EU.AddComponent(part3u);


               Box Car = new Box("Car");
               Box Spanish = new Box("Spanish");
               Box Portugal = new Box("Portugal");
               Car.AddComponent(Spanish);
               Car.AddComponent(Portugal);

               Product part1s = new Product("Fuel.mp3");
               Product part2s = new Product("Food.mp3");
               Product part3s = new Product("Drugs.mp3");
               Spanish.AddComponent(part1s);
               Spanish.AddComponent(part2s);
               Spanish.AddComponent(part3s);

               Product part1p = new Product("Ammunition.mp3");
               Product part2p = new Product("Weapons.mp3");
               Product part3p = new Product("Shells.mp3");
               Portugal.AddComponent(part1p);
               Portugal.AddComponent(part2p);
               Portugal.AddComponent(part3p);

               Box Report = new Box("Raport");
               Report.AddComponent(Plane);
               Report.AddComponent(Car);

               Report.Display();
               
               Console.ReadKey();
          }
     }
}
