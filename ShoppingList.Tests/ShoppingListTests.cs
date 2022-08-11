using NUnit.Framework;
using NSubstitute;
using ShoppingList;

namespace ShoppingList.Tests;

public class ShoppingListTests
{
    [Test]
    public void ShoppingList_AddItem_ReturnsString()
    {
        ShoppingList list = new ShoppingList(); // Arrange

        string actual = list.AddItem("item"); // Act
        string expected = "item";

        Assert.That(actual, Is.EqualTo(expected)); // Assert
    }
}