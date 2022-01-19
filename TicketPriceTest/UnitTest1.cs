using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketPrice;

namespace TicketPriceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StudentPriceWithoutPromo()
        {
            Client client = new Student("","");
            var expected = 900;

            var actual = client.GetPrice();

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void OrdinaryPriceWithoutPromo()
        {
            Client client = new OrdinaryClient("", "");
            var expected = 950;

            var actual = client.GetPrice();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PensionerPriceWithoutPromo()
        {
            Client client = new Pensioners("", "");
            var expected = 850;

            var actual = client.GetPrice();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StudentPriceWithPromo()
        {
            Client client = new Student("", "",true);
            var expected = 810;

            var actual = client.GetPrice();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OrdinaryPriceWithPromo()
        {
            Client client = new OrdinaryClient("", "",true);
            var expected = 855;

            var actual = client.GetPrice();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PensionerPriceWithPromo()
        {
            Client client = new Pensioners("", "", true);
            var expected = 765;

            var actual = client.GetPrice();

            Assert.AreEqual(expected, actual);
        }
    }
}
