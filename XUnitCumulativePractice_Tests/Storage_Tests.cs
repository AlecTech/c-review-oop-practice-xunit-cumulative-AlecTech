using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using XUnitCumulativePractice;

namespace XUnitCumulativePractice_Tests
{
    public class Storage_Tests
    {
        [Fact]
        public void AddItem_ShouldAddItem()
        {
            // Arrange
            Item myItem = new Item("testItem");
            Storage myStorage = new Storage();
            // Act
          
            myStorage.AddItem(myItem);

            // Assert
            
            Assert.Single(myStorage.Contents);
        }

        [Fact]
        public void RemoveItem_ShouldRemoveItem()
        {
            //Arrange
            Storage myStorage = new Storage();
            myStorage.Contents = new List<Item>()
            {
                new Item("testItem1"),
                new Item("testItem2"),
                new Item("testItem3"),
                new Item("testItem4"),
                new Item("testItem5")
            };
            var last = myStorage.Contents.LastOrDefault();

            //Act
            myStorage.RemoveItem();

            //Assert
            Assert.Equal(4, myStorage.Contents.Count);
            Assert.DoesNotContain(last, myStorage.Contents);
        }
    }
}
