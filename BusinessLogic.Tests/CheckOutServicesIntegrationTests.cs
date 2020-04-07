using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TransactionScript.BusinessLogic.Tests
{
    [TestClass]
    public class CheckOutServicesIntegrationTests
    {
        [TestMethod]
        public void Close_ShouldReturnZeroBill_WhenNothingScanned()
        {
            // Arrange
            CheckOutServices.Start();

            // Act
            var bill = CheckOutServices.Close();

            // Assert
            bill.Should().NotBeNull();
            bill.TotalPrice.Should().Be(0);
        }

        [TestMethod]
        public void Close_ShouldReturnPositiveBill_WhenSomethingScanned()
        {
            // Arrange
            CheckOutServices.Start();
            CheckOutServices.Scan(12345678);

            // Act
            var bill = CheckOutServices.Close();

            // Assert
            bill.Should().NotBeNull();
            bill.TotalPrice.Should().BePositive();
        }
    }
}
