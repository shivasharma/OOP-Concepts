using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.Common.Test
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            //Act
            var actual = source.InsertSpace();
            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}
