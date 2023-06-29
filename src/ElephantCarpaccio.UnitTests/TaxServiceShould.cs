namespace ElephantCarpaccio.UnitTests;

public class TaxServiceShould
{
    [Fact]
    public void SelectTaxCorrespondingToState()
    {
        TaxService taxService = new();

        var taxPercentage = taxService.GetPercentageForState("TX");

        Assert.Equal(5.55m, taxPercentage); 
    }
}