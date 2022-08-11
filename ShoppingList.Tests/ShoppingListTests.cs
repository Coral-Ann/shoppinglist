using NUnit.Framework;
using NSubstitute;
using ShoppingList;

namespace ShoppingList.Tests;

public class ShoppingListTests
{
    [Test]
    public void ShoppingList_AddItem_ReturnsString()
    {
        ShoppingList shoppingList = new ShoppingList(); // Arrange
        shoppingList.AddItem("item");

        List<string> actual = shoppingList.itemList; // Act
        List<string> expected = new List<string>(){"item"};

        CollectionAssert.AreEqual(expected, actual); // Assert
    }
}