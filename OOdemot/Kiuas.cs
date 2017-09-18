/* TTOS0200 olo-ohjelmointi 
 * esimerkki Kiuas-luokka
 */
using System;

namespace JAMK.IT
{
  public class Kiuas
  {
    public bool OnkoPäällä { get; set; }
    public float Lämpötila { get; set; }

    float kosteus;
    public float Kosteus {
      get {return kosteus;}
      set
      {
        kosteus = value;
        if (kosteus < 0 || kosteus > 100)
        {
          kosteus = 0;
        }
      }
    }
  }
}
