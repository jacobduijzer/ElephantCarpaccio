using ElephantCarpaccio.Cli;

namespace ElephantCarpaccio.UnitTests;

public class DiscountServiceShould
{
   [Theory]
   [InlineData(100, 0)]
   [InlineData(1100, 3)]
   [InlineData(11000, 10)]
   [InlineData(110000, 15)]
   public void ReturnCorrectDiscountRate(decimal totalAmount, int expectedDiscountRate)
   {
      DiscountService discountService = new();

      var discountRate = discountService.GetDiscountRate(totalAmount);
      
      Assert.Equal(expectedDiscountRate, discountRate);
   }
}