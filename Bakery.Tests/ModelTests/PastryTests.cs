using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryCost_ReturnsPastryCost_Int()
    {
      //Arrange
      int pastryCost = 2;
      Pastry newPastry = new Pastry(pastryCost);

      //Act
      int result = newPastry.PastryCost;

      //Assert
      Assert.AreEqual(pastryCost, result);
    }

    [TestMethod]
     public void GetPastryQuantity_ReturnsPastryQuantity_Int()
     {
       //Arrange
       int pastryQuantity = 1;
       Pastry newPastry = new Pastry(pastryQuantity);

       //Act
       int result = newPastry.PastryQuantity;

       //Assert
       Assert.AreEqual(pastryQuantity, result);
     }

     [TestMethod]
     public void TallyPastryCost_ReturnsPastryCostTimesPastryQuantity_Int()
     {
       //Arrange
       int cartPastryQuantity = 1;
       int tallyPastryCostCheck = 2;
       Pastry newPastry = new Pastry (cartPastryQuantity);

      //Act
      int tallyPastryCost = newPastry.TallyPastryCost();
       
       //Assert
       Assert.AreEqual(tallyPastryCostCheck, tallyPastryCost);
     }

     [TestMethod]
     public void TallyPastryCost_ReturnsPastryCostDeal_Int()
     {
       //Arrange
       int cartPastryQuantity = 3;
       int tallyPastryCostCheck = 5;
       Pastry newPastry = new Pastry(cartPastryQuantity);

       //Act
       int tallyPastryCost = newPastry.TallyPastryCost();

       //Assert
       Assert.AreEqual(tallyPastryCostCheck, tallyPastryCost);
     }
  }
}
