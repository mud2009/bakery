using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_ConstructsBread_Bread()
    {
      int num = 4;
      Bread breadOne = new Bread(num);
      Assert.AreEqual(typeof(Bread), breadOne.GetType());
    }
    [TestMethod]
    public void BreadConstructor_GetsAmount_Int()
    {
      int num = 4;
      Bread breadOne = new Bread(num);
      Assert.AreEqual(num, breadOne.Amount);
    }

    [TestMethod]
    public void BreadConstructor_SetsAmount_Int()
    {
      int num = 4;
      Bread breadOne = new Bread(num);
      breadOne.Amount = 5;
      int updatedNum = 5;
      Assert.AreEqual(updatedNum, breadOne.Amount);
    }

    [TestMethod]
    public void GetPrice_ReturnsInt_Int()
    {
      int num = 1;
      Bread breadOne = new Bread(num);
      Assert.AreEqual(5, breadOne.GetPrice());
    }

    [TestMethod]
    public void GetPrice_Returns0_Int()
    {
      int num = 0;
      Bread breadOne = new Bread(num);
      Assert.AreEqual(0, breadOne.GetPrice());
    }
    [TestMethod]
    public void GetPrice_Return10_Int()
    {

      int num = 2;
      Bread breadOne = new Bread(num);
      Assert.AreEqual(10, breadOne.GetPrice());
    }
    [TestMethod]
    public void GetPrice_Return10WithAmount3_Int()
    {
      int num = 3;
      Bread breadOne = new Bread(num);
      Assert.AreEqual(10, breadOne.GetPrice());
    }
  }
}