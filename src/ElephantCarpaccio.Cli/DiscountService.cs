namespace ElephantCarpaccio.Cli;

public class DiscountService
{
    public readonly Dictionary<decimal, int> DiscountRates = new()
    {
        { 1000, 3},
        { 5000, 5},
        { 7000, 7},
        { 10000, 10},
        { 50000, 15},
    };

    public decimal GetDiscountRate(decimal totalAmount) =>
        DiscountRates.LastOrDefault(x => totalAmount >= x.Key).Value;
}