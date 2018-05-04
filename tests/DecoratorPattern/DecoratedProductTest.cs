namespace DesignPatternsTest.DecoratorPattern
{
    using System;
    using PatternSamples.Decorator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PatternSamples.Common;

    [TestClass]
    public class DiscountProductTest
    {
        [TestMethod]
        public void DecoratedProduct_Create_Ok()
        {
            var name = "Mobile Phone";
            var price = 399.99m;
            var stock = 100;

            var p = new DecoratedProduct(name, price, stock);

            Assert.IsInstanceOfType(p, typeof(IProduct));
            Assert.AreEqual(name, p.Name);
            Assert.AreEqual(price, p.Price);
            Assert.AreEqual(stock, p.StockUnits);
        }

        [TestMethod]
        public void DecoratedProduct_ValidUpdateStock_Ok()
        {
            var name = "Mobile Phone";
            var price = 399.99m;
            var stock = 100;
            var qtty = 17;

            var p = new DecoratedProduct(name, price, stock);
            p.Sold(qtty);

            Assert.AreEqual(stock - qtty, p.StockUnits);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DecoratedProduct_InvalidUpdateStock_Exception()
        {
            var name = "Mobile Phone";
            var price = 399.99m;
            var stock = 100;

            var p = new DecoratedProduct(name, price, stock);
            p.Sold(-1);
        }
    }
}
