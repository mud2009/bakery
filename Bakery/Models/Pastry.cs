namespace Bakery.Models
{
  public class Pastry
  {
    public int Amount{ get; set; }

    public Pastry(int amount)
    {
      Amount = amount;
    }

    public int GetPrice()
    {
      return 5;
    }
  }
}