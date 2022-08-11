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
        ShoppingItem mockShoppingItem = Substitute.For<ShoppingItem>("item", 3.99);
        shoppingList.AddItem(mockShoppingItem);

        List<ShoppingItem> actual = shoppingList.itemList;
        List<ShoppingItem> expected = new List<ShoppingItem>() { mockShoppingItem }; // Act

        Assert.That(actual, Is.EqualTo(expected)); // Assert
    }

    [Test]
    public void ShoppingList_GetItem_ReturnsList()
    {
        ShoppingItem mockShoppingItem1 = Substitute.For<ShoppingItem>("item1", 3.99);
        ShoppingItem mockShoppingItem2 = Substitute.For<ShoppingItem>("item2", 10.99);
        ShoppingList shoppingList = new ShoppingList(); // Arrange
        shoppingList.AddItem(mockShoppingItem1);
        shoppingList.AddItem(mockShoppingItem2);

        List<ShoppingItem> actual = shoppingList.GetItems(); // Act
        List<ShoppingItem> expected = new List<ShoppingItem>(){ mockShoppingItem1, mockShoppingItem2 };

        CollectionAssert.AreEqual(expected, actual); // Assert
    }
}



