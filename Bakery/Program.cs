using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      System.Console.WriteLine("Welcome to the bakery");
      System.Console.WriteLine("One loaf of bread is $5");
      System.Console.WriteLine("One pastry is $2");
      System.Console.WriteLine("How many loaves of bread would you like?");
      string stringLoaves = Console.ReadLine();
      int loaves;
      bool loavesSuccess = int.TryParse(stringLoaves, out loaves);
      if (loavesSuccess)
      {
        // whatever the code should do
      }
      else
      {
        System.Console.WriteLine("---Please enter a number---");
        Main();
      }
      System.Console.WriteLine("How many pastries would you like?");
      string stringPastries = Console.ReadLine();
      int pastries;
      bool pastriesSuccess = int.TryParse(stringPastries, out pastries);
      if (pastriesSuccess)
      {
        // whatever the code should do
      }
      else
      {
        System.Console.WriteLine("---Please enter a number---");
        Main();
      }
    }
  }
}
