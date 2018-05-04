namespace PatternSamples.Common
{
    public interface IProduct
    {
        string Name { get; }

        // It's a good practice to use Decimal for financial values to avoid eventual rounding errors propagation
        decimal Price { get; }
    }
}
