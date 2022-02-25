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
      Bread breadOne = new Bread();
      Assert.AreEqual(typeof(Bread), breadOne.GetType());
    }
    [TestMethod]
    public void BreadConstructor_GetsAmount_Int()
    {
      int num = 4;
      Bread breadOne = new Bread(num);
      Assert.AreEqual(num, breadOne.Amount);
    }
  }
}