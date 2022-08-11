using NUnit.Framework;
using NSubstitute;
using ShoppingList;

namespace ShoppingList.Tests
{
  public class ShoppingItemTests 
  {
    [Test]
    public void ShoppingItem_CreatesItemToAddProperty()
    {
      ShoppingItem testitem = new ShoppingItem("item", 4.99); // Arrange

      string actual = testitem.item; // Act
      string expected = "item";

      Assert.That(actual, Is.EqualTo(expected)); // Assert
    }
    [Test]
    public void ShoppingItem_CreatesPriceProperty()
    {
      ShoppingItem item = new ShoppingItem("itemToAdd", 4.99); // Arrange

      double actual = item.price; // Act
      double expected = 4.99;

      Assert.That(actual, Is.EqualTo(expected)); // Assert
    }
  }
}
