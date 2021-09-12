using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set; } = 5;
    public int BreadQuantity { get; set; }

    public Bread(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
    }

    public int TallyBreadCost()
    {
      int breadDeal = BreadCost * ((BreadQuantity - (BreadQuantity % 3)) / 3);
      int tallyBreadCost = (BreadQuantity * BreadCost) - breadDeal;
      return tallyBreadCost;
    } 
  }
}