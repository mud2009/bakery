namespace Bakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }

    public Bread(int amount)
    {
      Amount = amount;
    }

    public int GetPrice(){
      if (this.Amount == 1)
      {
        return 5;
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