using ElephantCarpaccio.Cli;

namespace ElephantCarpaccio.UnitTests;

public class TaxServiceShould
{
    [Theory]
    [InlineData("UT", 6.85)]
    [InlineData("AL", 4)]
    [InlineData("??", 0)]
    public void SelectTaxCorrespondingToState(string state, decimal expectedTaxPercentage)
    {
        TaxService taxService = new();

        var taxPercentage = taxService.GetPercentageForState(state);

        Assert.Equal(expectedTaxPercentage, taxPercentage); 
    }
}