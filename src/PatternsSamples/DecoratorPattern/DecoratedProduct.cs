namespace PatternSamples.Decorator
{
    using System;
    using PatternSamples.Common;

    /// <summary>
    /// Represents a product with additional stock quantity information using "Decorator Pattern".
    /// </summary>
    public class DecoratedProduct : IProduct
    {
        private readonly IProduct product;
        public string Name => product.Name;

        public decimal Price => product.Price;

        public int StockUnits { get; private set; }

        public DecoratedProduct(string name, decimal price, int stockUnits)
        {
            this.product = new Product(name, price);
            this.StockUnits = stockUnits;
        }

        /// <summary>
        /// Updates the stock of the product.
        /// </summary>
        /// <param name="quantity">Quantity of products sold. If higher than current stock, raises an exception.</param>
        /// <returns>Updated stock quantity.</returns>
        public int Sold(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException("Quantity of product has to be greater than 0!");
            }

            if (this.StockUnits < quantity)
            {
                throw new ArgumentOutOfRangeException($"There's not {this.StockUnits} units of '{this.Name}' in stock!");
            }

            return (this.StockUnits -= quantity);
        }
    }
}
