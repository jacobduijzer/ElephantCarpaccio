using ElephantCarpaccio.Cli;

namespace ElephantCarpaccio.UnitTests;

public class TaxServiceShould
{
    [Fact]
    public void SelectTaxCorrespondingToState()
    {
        TaxService taxService = new();

        var taxPercentage = taxService.GetPercentageForState("TX");

        Assert.Equal(6.25m, taxPercentage); 
    }
}