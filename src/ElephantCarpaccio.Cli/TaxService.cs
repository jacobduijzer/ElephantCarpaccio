namespace ElephantCarpaccio.Cli;

public class TaxService
{
    public readonly Dictionary<string, decimal> TaxRates = new()
    {
        {"UT", 6.85m},
        {"NV", 8},
        {"TX", 6.25m},
        {"AL", 4},
        {"CA", 8.25m}
    };

    public decimal GetPercentageForState(string state) =>
        TaxRates.TryGetValue(state, out decimal taxPercentage) ? taxPercentage : 0;
}