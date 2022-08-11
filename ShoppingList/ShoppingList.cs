using System;
using System.Text;
using System.Collections.Generic;

namespace ShoppingList;

public class ShoppingList
{
  public readonly List<string> itemList;

  public ShoppingList()
  {
    itemList = new List<string>();
  }

  public void AddItem(string item)
  {
    itemList.Add(item);
  }
}