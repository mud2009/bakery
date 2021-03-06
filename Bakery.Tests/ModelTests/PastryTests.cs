using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_ConstructsPastry_Pastry()
    {
      int num = 1;
      Pastry pastryOne = new Pastry(num);
      Assert.AreEqual(typeof(Pastry), pastryOne.GetType());
    }

    [TestMethod]
    public void PastryConstructor_GetsAmount_Int()
    {
      int num = 1;
      Pastry pastryOne = new Pastry(num);
      Assert.AreEqual(num, pastryOne.Amount);
    }
    [TestMethod]
    public void PastryConstructor_SetAmount_Int()
    {
      int num = 1;
      Pastry pastryOne = new Pastry(num);
      pastryOne.Amount = 2;
      int updatedNum = 2;
      Assert.AreEqual(updatedNum, pastryOne.Amount);
    }
    [TestMethod]
    public void GetPrice_ReturnInt_Int()
    {
      int num = 1;
      Pastry pastryOne = new Pastry(num);
      Assert.AreEqual(2, pastryOne.GetPrice());
    }
    [TestMethod]
    public void GetPrice_Return0_Int()
    {
      int num = 0;
      Pastry pastryOne = new Pastry(num);
      Assert.AreEqual(0, pastryOne.GetPrice());
    }
    [TestMethod]
    public void GetPrice_Return4_Int()
    {
      int num = 2;
      Pastry pastryOne = new Pastry(num);
      Assert.AreEqual(4, pastryOne.GetPrice());
    }
    [TestMethod]
    public void GetPrice_Return5_Int()
    {
      int num = 3;
      Pastry pastryOne = new Pastry(num);
      Assert.AreEqual(5, pastryOne.GetPrice());
    }
  }
}