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
        return 2;
      }
      else if (this.Amount ==2)
      {
        return 10;
      }
      else
      {
        return 0;
      }
    }
  }
}