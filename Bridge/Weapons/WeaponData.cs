namespace Bridge.Data
{
     class WeaponData : IData
     {
          private string _title;
          private string _factoryDescription;
          private string _imageUrl;

          public WeaponData(string title, string factoryDescription, string imageUrl)
          {
               _title = title;
               _factoryDescription = factoryDescription;
               _imageUrl = imageUrl;
          }


          public string GetImageUrl()
          {
               return _imageUrl;
          }

          public string GetBullet()
          {
               return _factoryDescription;
          }

          public string GetTitle()
          {
               return _title;
          }

     }
}
