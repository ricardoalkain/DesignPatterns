namespace DesignPatternsTest.CompositePattern
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PatternSamples.Common;

    [TestClass]
    public class SimpleProductTest
    {
        [TestMethod]
        public void CreateSimpleProduct()
        {
            var name = "Mobile Phone";
            var price = 499.99m;

            IProduct product = new Product(name, price);

            Assert.AreEqual(name, product.Name);
            Assert.AreEqual(price, product.Price);
        }
    }
}
