using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRentalStore;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_Rented_Copies_By_MovieID()
        {
            // Arrange
            var data = new Database();

            // Act
            var actual = data.HasCopiesRented(1);

            // Assert
            Assert.AreNotEqual(0, actual);
        }

        [TestMethod]
        public void Get_Rented_Copies_By_Customer()
        {
            // Arrange
            var data = new Database();

            // Act
            var actual = data.UserHasRentedMovies(1);

            // Assert
            Assert.AreNotEqual(1, actual);
        }
    }
}
