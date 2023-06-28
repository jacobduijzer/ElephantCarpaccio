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
   [InlineData(1, 1.50, 1.50)]
   [InlineData(10, 1, 10)]
   [InlineData(10, 1.99, 19.90)]
   [InlineData(100, 1.99, 199)]
   public void CalculateTotalPriceWithoutTax(int numberOfItems, decimal pricePerItem, decimal expectedTotalPrice)

   {
      RetailCalculator retailCalculator = new();
      retailCalculator.SetNumberOfItems(numberOfItems);
      retailCalculator.SetPricePerItem(pricePerItem);

      var totalPriceExclTax = retailCalculator.CalculateTotalExcludingTax();

      Assert.Equal(expectedTotalPrice, totalPriceExclTax);
   }
}