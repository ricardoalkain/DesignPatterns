namespace DesignPatternsTest.CompositePattern
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PatternSamples.Common;
    using PatternSamples.Composite;

    [TestClass]
    public class ComposedProductTest
    {
        [TestMethod]
        public void ProductsAdd_AddSimple_CorrectPriceAndCount()
        {
            var pack = new CompositeProduct();

            pack.Add(new Product("Mouse", 14.50m))
                .Add(new Product("Keyboard", 30.00m));

            Assert.AreEqual(2, pack.Count);
            Assert.AreEqual(44.50m, pack.Price);
        }

        [TestMethod]
        public void ProductAdd_AddComposite_CorrectPriceAndCount()
        {
            var inputDevices = new CompositeProduct();
            inputDevices.Add(new Product("Mouse", 14.50m))
                        .Add(new Product("Keyboard", 30.00m));

            var pc = new CompositeProduct();
            pc.Add(new Product("i7 16GB 1TB", 500.00m))
              .Add(new Product("Monitor", 100.00m))
              .Add(new Product("Printer", 200.00m))
              .Add(inputDevices);

            Assert.AreEqual(5, pc.Count);
            Assert.AreEqual(844.50m, pc.Price);
        }
    }
}
