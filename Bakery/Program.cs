using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      System.Console.WriteLine("  Welcome to Pierre's bakery");
      System.Console.WriteLine("  One loaf of bread is $5");
      System.Console.WriteLine("  One pastry is $2");
      System.Console.WriteLine("  How many loaves of bread would you like?");
      string stringLoaves = Console.ReadLine();
      int loaves;
      while(!int.TryParse(stringLoaves, out loaves))
      {
        System.Console.WriteLine("  ---Please enter a number of loaves---");
        stringLoaves = Console.ReadLine();
      }
      Bread breadCount = new Bread(loaves);
      System.Console.WriteLine("  How many pastries would you like?");
      string stringPastries = Console.ReadLine();
      int pastries;
      while(!int.TryParse(stringPastries, out pastries))
      {
        System.Console.WriteLine("  ---Please enter a number of pastries---");
        stringPastries = Console.ReadLine();
      }
      Pastry pastryCount = new Pastry(pastries);
      int totalCost = breadCount.GetPrice() + pastryCount.GetPrice();
      System.Console.WriteLine($" {breadCount.Amount} loaves of bread for ${breadCount.GetPrice()}");
      System.Console.WriteLine($" {breadCount.Amount} pastries for ${pastryCount.GetPrice()}");
      System.Console.WriteLine($" Your total will be ${totalCost}");
    }
  }
}
