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
  }
}  