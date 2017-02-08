using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        public void RetrieveOrderDisplayTest()
        {
            var orderRepository = new OrderRepository();
            var exprected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "BagShot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        OrderQuantity = 2,
                        ProductName = "Sunflowers",
                        PurchasePrice = 15.96M

                    },
                    new OrderDisplayItem()
                    {
                        OrderQuantity = 3,
                        ProductName = "Sunflowers1",
                        PurchasePrice = 145.96M

                    }
                }
            };

            var actual = orderRepository.RetrieveOderDisplay(10);
        }
    }
}
