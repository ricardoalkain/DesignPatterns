namespace PatternSamples.Common
{
    /// <summary>
    /// Represents a single product.
    /// </summary>
    public class Product : IProduct
    {
        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Creates a new single product.
        /// </summary>
        /// <param name="name">Name of the product.</param>
        /// <param name="price">Price of the product.</param>
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
