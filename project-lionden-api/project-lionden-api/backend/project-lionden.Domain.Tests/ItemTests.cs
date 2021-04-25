using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace project_lionden.Domain.Tests
{
    [TestClass]
    public class UnitTest2
    {
[TestMethod]
public void Can_Create_New_Item()
{
	var item = new Item("Name", "Description", "Brand", 10.00m);
 
Assert.AreEqual("Name", item.Name);
Assert.AreEqual("Description", item.Description);
Assert.AreEqual("Brand", item.Brand);
Assert.AreEqual(10.00m, item.Price);
}
[TestMethod]
public void Can_Create_Add_Rating()
{
	//Arrange
	var item = new Item("Name", "Description", "Brand", 10.00m);
	var ratini = new Rating(5, "Name", "Review");
 
	//Act
	Item.AddRating(rating);
 
	//Assert
Assert.AreEqual(rating, item.Rating[0]);
}

	}
}