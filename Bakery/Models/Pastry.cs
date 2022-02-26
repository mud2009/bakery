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
      if (this.Amount > 0)
      {
        int cost = 0;
        for (int i = 1; i <= this.Amount; i ++)
        {
          if (i % 3 == 0)
          {
            cost += 1;
          }
          else
          {
            cost += 2;
          }
        }
        return cost;
      }
      else
      {
        return 0;
      }
    }
  }
}