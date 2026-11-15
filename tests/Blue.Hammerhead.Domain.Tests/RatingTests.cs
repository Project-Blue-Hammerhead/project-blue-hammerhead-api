
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blue.Hammerhead.Domain.Catalog;

namespace Blue.Hammerhead.Domain.Tests
{
    [TestClass]
    public class RatingTests
    {
        [TestMethod]
        public void Can_Create_New_Rating()
        {
            // Arrange
            var rating = new Rating(1, "Mike", "Great fit!");

            // Assert
            Assert.AreEqual(1, rating.Stars);
            Assert.AreEqual("Mike", rating.UserName);
            Assert.AreEqual("Great fit!", rating.Review);
        }

        [TestMethod]
        public void Cannot_Create_Rating_With_Invalid_Stars()
        {
            Assert.ThrowsExactly<ArgumentException>(
                () => new Rating(0, "Mike", "Great fit!"));
        }
    }
}


