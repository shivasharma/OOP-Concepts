using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace Acme.Common.Test
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer()
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList  =null
            };

            changedItems.Add(customer as ILoggable);
            //Act
            LoggingService.WrtieToFile(changedItems);
        }
    }
}
