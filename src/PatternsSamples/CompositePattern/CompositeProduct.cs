namespace PatternSamples.Composite
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using PatternSamples.Common;

    /// <summary>
    /// Represents a pack of single products using "Composite Pattern"
    /// </summary>
    public class CompositeProduct : IProduct, IEnumerable<IProduct>
    {
        private readonly List<IProduct> products;

        /// <summary>
        /// Group name composed by all product names in it (recursive) separated by comma
        /// </summary>
        public string Name => "{" + string.Join(", ", products.Select(p => p.Name)) + "}";

        /// <summary>
        /// Total price of all products in the group
        /// </summary>
        public decimal Price => products.Sum(p => p.Price);

        /// <summary>
        /// Creates a new group of products.
        /// </summary>

        /// <summary>
        /// Total number of products in the group (recursive)
        /// </summary>
        public int Count
        {
            // Let's do it recursively just to make things a little more funny.
            // In a real world app, a simple '<see cref="this.products"/>.Count' could be enough.
            get
            {
                var count = 0;
                foreach (var product in this.products)
                {
                    count += (product as CompositeProduct)?.Count ?? 1;
                }
                return count;
            }
        }

        /// <summary>
        /// Creates a new group of products.
        /// </summary>
        public CompositeProduct()
        {
            this.products = new List<IProduct>();
        }

        /// <summary>
        /// Adds a product to the group.
        /// </summary>
        /// <param name="product">Prodcut to be included in the product group.</param>
        public CompositeProduct Add(IProduct product)
        {
            this.products.Add(product);
            return this;
        }

        /// <summary>
        /// Removes a product to the group.
        /// </summary>
        /// <param name="product">Prodcut to be removed from the product group.</param>
        public CompositeProduct Remove(IProduct product)
        {
            this.products.Remove(product);
            return this;
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            return this.products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.products.GetEnumerator();
        }
    }
}
