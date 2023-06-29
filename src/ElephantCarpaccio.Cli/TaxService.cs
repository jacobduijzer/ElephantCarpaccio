namespace ElephantCarpaccio.Cli;

public class TaxService
{
    private readonly Dictionary<string, decimal> _taxRates = new()
    {
        {"UT", 6.85m},
        {"NV", 8},
        {"TX", 6.25m},
        {"AL", 4},
        {"CA", 8.25m}
    };

    public decimal GetPercentageForState(string state) =>
        _taxRates.TryGetValue(state, out decimal taxPercentage) ? taxPercentage : 0;
}