namespace ElephantCarpaccio.Cli;

public class DiscountService
{
    private readonly Dictionary<decimal, int> _discountRates = new()
    {
        { 1000, 3},
        { 5000, 5},
        { 7000, 7},
        { 10000, 10},
        { 50000, 55},
    };

    public int GetDiscountRate(decimal totalAmount)
    {
        var discount = _discountRates.FirstOrDefault(x => x.Key <= totalAmount).Value;
        if (discount != 0)
            return discount;

        return 0;
    }
}