using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadCost_ReturnsBreadCost_Int()
    {
      //Arrange
      int breadCost = 5;
      Bread newBread = new Bread(breadCost);

      //Act
      int result = newBread.BreadCost;

      //Assert
      Assert.AreEqual(breadCost, result);
    }

    [TestMethod]
     public void GetBreadQuantity_ReturnsBreadQuantity_Int()
     {
       //Arrange
       int breadQuantity = 1;
       Bread newBread = new Bread(breadQuantity);

       //Act
       int result = newBread.BreadQuantity;

       //Assert
       Assert.AreEqual(breadQuantity, result);
     }

     [TestMethod]
     public void TallyBreadCost_ReturnsBreadCostTimesBreadQuantity_Int()
     {
       //Arrange
       int cartBreadQuantity = 1;
       int tallyBreadCostCheck = 5;
       Bread newBread = new Bread (cartBreadQuantity);

      //Act
      int tallyBreadCost = newBread.TallyBreadCost();
       
       //Assert
       Assert.AreEqual(tallyBreadCostCheck, tallyBreadCost);
     }

     [TestMethod]
     public void TallyBreadCost_ReturnsBreadCostDeal_Int()
     {
       //Arrange
       int cartBreadQuantity = 3;
       int tallyBreadCostCheck = 10;
       Bread newBread = new Bread(cartBreadQuantity);
       //Act
       int tallyBreadCost = newBread.TallyBreadCost();

       //Assert
       Assert.AreEqual(tallyBreadCostCheck, tallyBreadCost);
     }

  }  
}