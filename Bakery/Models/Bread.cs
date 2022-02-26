namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }

    public Bread(int amount)
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
            cost += 0;
          }
          else
          {
            cost += 5;
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