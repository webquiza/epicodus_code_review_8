using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost { get; set; }

    public Pastry(int pastryCost)
    {
      PastryCost = pastryCost;
    }
  }
}