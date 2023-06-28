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

   [Fact]
   public void CalculateTotalPriceWithoutTax()
   {
      RetailCalculator retailCalculator = new();
      retailCalculator.SetNumberOfItems(10);
      retailCalculator.SetPricePerItem(1m);

      var totalPriceExclTax = retailCalculator.CalculateTotalExludingTax();
      
      Assert.Equal(10m, totalPriceExclTax);
   }
}