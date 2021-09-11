using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost { get; }

    public Pastry(int pastryCost)
    {
      PastryCost = pastryCost;
    }
  }
}