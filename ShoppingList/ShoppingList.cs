using System;
using System.Text;
using System.Collections.Generic;

namespace ShoppingList;

public class ShoppingList
{
  public readonly List<ShoppingItem> itemList;

  public ShoppingList()
  {
    itemList = new List<ShoppingItem>();
  }

  public void AddItem(ShoppingItem item)
  {
    itemList.Add(item);
  }
    public List<ShoppingItem> GetItems()
  {
    return itemList;
  }
}
