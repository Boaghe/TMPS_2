namespace Bridge.Data
{
     class FactoryData : IData
     {
          private string _title;
          private string _info;
          private string _imageUrl;

          public FactoryData(string title, string info, string imageUrl)
          {
               _title = title;
               _info = info;
               _imageUrl = imageUrl;
          }


          public string GetImageUrl()
          {
               return _imageUrl;
          }

          public string GetBullet()
          {
               return _info;
          }

          public string GetTitle()
          {
               return _title;
          }

     }
}
