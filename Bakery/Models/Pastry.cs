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
      if (this.Amount == 1)
      {
        return 5;
      }
      else
      {
        return 0;
      }
    }
  }
}