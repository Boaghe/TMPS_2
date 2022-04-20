using Bridge.Data;
using Bridge.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
     class Program
     {
          static void Main(string[] args)
          {
               View longView = new LongView();

               longView.Data = new WeaponData("Scope", "Average long distance" , "some points..");
               string text = longView.Generate();
               Console.WriteLine(text);

               longView.Data = new FactoryData("AKM", "7,44 x 23", "some image");
               text = longView.Generate();
               Console.WriteLine(text);

               Console.ReadKey();
          }
     }
}
