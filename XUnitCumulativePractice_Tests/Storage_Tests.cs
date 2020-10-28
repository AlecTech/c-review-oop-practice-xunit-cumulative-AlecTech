using System;
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

        
    }
}
