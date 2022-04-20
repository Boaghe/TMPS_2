using System;

namespace Bridge.Views
{
     class ShortView : View
     {
          public override string Generate()
          {
               string text = "";
               Console.WriteLine("Generating Short View");

               text = $"Title: {Data.GetTitle()}\n" +
                         $"ImageUrl: {Data.GetImageUrl()}\n";

               return text;
          }
     }
}
