using System;
using System.Text;

namespace ShoppingList;


public class ShoppingItem
{
  public readonly string item;
  public readonly double price;

  public ShoppingItem(string itemToAdd, double priceToAdd)
  {
    item = itemToAdd;
    price = priceToAdd;
  }
}