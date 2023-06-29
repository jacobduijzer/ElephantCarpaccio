namespace ElephantCarpaccio.Cli;

public class DiscountService
{
    private readonly Dictionary<decimal, int> _discountRates = new()
    {
        { 1000, 3},
        { 5000, 5},
        { 7000, 7},
        { 10000, 10},
        { 50000, 15},
    };

    public int GetDiscountRate(decimal totalAmount) =>
        _discountRates.LastOrDefault(x => totalAmount >= x.Key).Value;
}