using ElephantCarpaccio.Cli;

namespace ElephantCarpaccio.UnitTests;

public class RetailCalculatorShould
{
   [Fact]
   public void AcceptNumberOfItemsAsParameter()
   {
      RetailCalculator retailCalculator = new(new DiscountService());

      retailCalculator.SetNumberOfItems(10);
      
      Assert.Equal(10, retailCalculator.NumberOfItems);
   }

   [Fact]
   public void AcceptItemPriceAsParameter()
   {
      RetailCalculator retailCalculator = new(new DiscountService());

      retailCalculator.SetPricePerItem(5.99m);
      
      Assert.Equal(5.99m, retailCalculator.PricePerItem);
   }

   [Fact]
   public void AcceptTaxPercentageAsParameter()
   {
      RetailCalculator retailCalculator = new(new DiscountService());

      retailCalculator.SetTaxPercentage(5.5m);
      
      Assert.Equal(5.5m, retailCalculator.TaxPercentage);
   }
   
   [Theory]
   [InlineData(12, 12.2, 5.5, 154.4520)]
   [InlineData(12, 12.2, 6.25, 155.55000)]
   [InlineData(1000, 1, 6.85, 1036.445)]
   [InlineData(1000, 10, 6.85, 9616.50000)]
   [InlineData(1000, 100, 6.85, 90822.500000)]
   public void CalculateTotalPriceWithTax(int numberOfItems, decimal pricePerItem, decimal taxPercentage, decimal expectedTotalPrice)
   {
      RetailCalculator retailCalculator = new(new DiscountService());
      retailCalculator.SetNumberOfItems(numberOfItems);
      retailCalculator.SetPricePerItem(pricePerItem);
      retailCalculator.SetTaxPercentage(taxPercentage);

      var totalPriceExclTax = retailCalculator.CalculateTotal();

      Assert.Equal(expectedTotalPrice, totalPriceExclTax);
   }
}