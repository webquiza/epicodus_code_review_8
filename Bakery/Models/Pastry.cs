using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost { get; set; } = 2;
    public int PastryQuantity { get; set; }

    public Pastry(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
    }
  }
}