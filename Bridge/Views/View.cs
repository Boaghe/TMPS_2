using System;
using Bridge.Data;

namespace Bridge.Views
{
     abstract class View
     {
          public IData Data { get; set; }
          public abstract string Generate();
     }
}
