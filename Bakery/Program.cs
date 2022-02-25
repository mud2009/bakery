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
      int userLoaves = int.Parse(Console.ReadLine());
      System.Console.WriteLine("How many pastries would you like?");
      int userPastries = int.Parse(Console.ReadLine());
    }
  }
}
