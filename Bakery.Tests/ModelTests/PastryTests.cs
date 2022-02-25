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
  }
}