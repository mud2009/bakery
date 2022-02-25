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
      Pastry pastryOne = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastryOne.GetType());
    }
  }
}