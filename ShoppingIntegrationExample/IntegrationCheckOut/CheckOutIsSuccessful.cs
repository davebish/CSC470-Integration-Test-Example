using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingIntegrationExample;

namespace IntegrationCheckOut
{
    [TestClass]
    public class CheckOutIsSuccessful
    {
        [TestMethod]
        public void CheckOut()
        {
            // Arrange
            const string STATE = "South Dakota";
            const decimal EXPECTED_TOTAL_WITHOUT_TAX = 1400.00M;
            const decimal EXPECTED_TAX = 63.00M;
            const decimal EXPECTED_TOTAL_WITH_TAX = EXPECTED_TOTAL_WITHOUT_TAX + EXPECTED_TAX;
            const int SHOPPER_ID = 1;
            const string SHOPPER_NAME = "Tiger";
            const string SHOPPER_STATE = STATE;
            const int QUANTITY = 1;

            Shopper shopper = new Shopper(SHOPPER_ID, SHOPPER_NAME, SHOPPER_STATE);

            const decimal CALLAWAY_IRON_PRICE = 900.00M;
            Item CallawayIrons = new Item ("Mavrik Irons", CALLAWAY_IRON_PRICE);
            shopper.Add(CallawayIrons, QUANTITY);

            const decimal CALLAWAY_DRIVER_PRICE = 500.00M;
            Item CallawayDriver = new Item("Mavrik Driver", CALLAWAY_DRIVER_PRICE);
            shopper.Add(CallawayIrons, QUANTITY);

            // Act
            decimal ActualTotalWithTax = shopper.CheckOut();

            // Assert
            Assert.AreEqual(EXPECTED_TOTAL_WITH_TAX, ActualTotalWithTax);
        }
    }
}
