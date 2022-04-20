using System;

namespace Bridge.Views
{
     class Preview : View
     {
          public override string Generate()
          {
               string text = "";
               Console.WriteLine("Generating Long View");

               text = $"ImageUrl: {Data.GetImageUrl()}\n";

               return text;
          }
     }
}
