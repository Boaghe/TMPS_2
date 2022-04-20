using System;

namespace Bridge.Views
{
     class LongView : View
     {

          public override string Generate()
          {
               string text = "";
               Console.WriteLine("Generating Long View");

               text = $"Title: {Data.GetTitle()}\n" +
                         $"ImageUrl: {Data.GetImageUrl()}\n" +
                         $"Bullet: {Data.GetBullet()}\n";

               return text;
          }
     }
}
