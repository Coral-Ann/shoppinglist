using NUnit.Framework;
using NSubstitute;
using ShoppingList;

namespace ShoppingList.Tests;

public class ShoppingListTests
{
    [Test]
    public void ShoppingList_AddItem_AddsItemToList()
    {
        ShoppingList shoppingList = new ShoppingList(); // Arrange
        shoppingList.AddItem("item");

        List<string> actual = shoppingList.itemList; // Act
        List<string> expected = new List<string>(){"item"};

        CollectionAssert.AreEqual(expected, actual); // Assert
    }
    [Test]
    public void ShoppingList_GetItem_ReturnsList()
    {
        ShoppingList shoppingList = new ShoppingList(); // Arrange
        shoppingList.AddItem("item1");
        shoppingList.AddItem("item2");

        List<string> actual = shoppingList.GetItem(); // Act
        List<string> expected = new List<string>(){"item1", "item2"};

        CollectionAssert.AreEqual(expected, actual); // Assert
    }
}