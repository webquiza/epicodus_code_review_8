using System;
using System.Collections.Generic;
using Bakery.Models;


public class Program 
{
  public static void Main()
  {
    Console.WriteLine("Hi, welcome to Pierre's Bakery");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Please look at our menu selections and current deals");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Our bread is $5 for each loaf, or you can buy 2 and get 1 for free");
    Console.WriteLine("Our pastries are currently $2 each or you can buy 3 for $5");
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("Please enter how many loaves of bread you want today");
    string stringBreadQuantity = Console.ReadLine();
    int BreadQuantity = int.Parse(stringBreadQuantity);
    Console.WriteLine("Please enter how many pastries you want today");
    string stringPastryQuantity = Console.ReadLine();
    int PastryQuantity = int.Parse(stringPastryQuantity);
    Bread cartBread = new Bread(BreadQuantity);
    Pastry cartPastry = new Pastry(PastryQuantity);
    int tallyCost = cartBread.TallyBreadCost() + cartPastry.TallyPastryCost();
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("Your total today is $" + tallyCost + ". Enjoy and please come back!");
  }
}
