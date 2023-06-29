using ElephantCarpaccio.Cli;

namespace ElephantCarpaccio.UnitTests;

public class RetailCalculatorShould
{
   [Fact]
   public void AcceptNumberOfItemsAsParameter()
   {
      RetailCalculator retailCalculator = new();

      retailCalculator.SetNumberOfItems(10);
      
      Assert.Equal(10, retailCalculator.NumberOfItems);
   }

   [Fact]
   public void AcceptItemPriceAsParameter()
   {
      RetailCalculator retailCalculator = new();

      retailCalculator.SetPricePerItem(5.99m);
      
      Assert.Equal(5.99m, retailCalculator.PricePerItem);
   }

   [Theory]
   [InlineData(1000, 1, 1068.5)]
   [InlineData(12, 12.2, 156.4284)]
   public void CalculateTotalPriceWithFixedTax(int numberOfItems, decimal pricePerItem, decimal expectedTotalPrice)
   {
      RetailCalculator retailCalculator = new();
      retailCalculator.SetNumberOfItems(numberOfItems);
      retailCalculator.SetPricePerItem(pricePerItem);

      var totalPriceExclTax = retailCalculator.CalculateTotal();

      Assert.Equal(expectedTotalPrice, totalPriceExclTax);
   }

   [Fact]
   public void AcceptTaxPercentageAsParameter()
   {
      RetailCalculator retailCalculator = new();

      retailCalculator.SetTaxPercentage(5.5);
      
      Assert.Equal(5.5, retailCalculator.TaxPercentage);
   }
}