using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set; }

    public Bread(int breadCost)
    {
      BreadCost = breadCost;
    }
  }
}