using ElephantCarpaccio.Cli;

namespace ElephantCarpaccio.UnitTests;

public class DiscountServiceShould
{
   [Fact]
   public void ReturnCorrectDiscountRate()
   {
      DiscountService discountService = new();

      var discountRate = discountService.GetDiscountRate(1100);
      
      Assert.Equal(3, discountRate);
   }
}