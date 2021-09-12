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

     public int TallyPastryCost()  
    {
      if (PastryQuantity % 3 == 0) {
        int TallyPastryCost = (PastryQuantity / 3) * 5;
        return TallyPastryCost;
      }
      else if (PastryQuantity % 3 > 0 && PastryQuantity >3)
      {
        int TallyPastryCost = ((PastryQuantity / 3) *5) + ((PastryQuantity % 3) * PastryCost);
        return TallyPastryCost;
      }
      else
      {
      return PastryCost * PastryQuantity;
      }
    }
  }
}