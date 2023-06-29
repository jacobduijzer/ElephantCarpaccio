namespace ElephantCarpaccio.Cli;

public class RetailCalculator
{
    private readonly DiscountService _discountService;
    public int NumberOfItems { get; private set; }
    public decimal PricePerItem { get; private set; }
    public decimal TaxPercentage { get; private set; }
    
    public RetailCalculator(DiscountService discountService) =>
        _discountService = discountService;

    public void SetNumberOfItems(int numberOfItems) =>
        NumberOfItems = numberOfItems;

    public void SetPricePerItem(decimal pricePerItem) =>
        PricePerItem = pricePerItem;
    
    public void SetTaxPercentage(decimal taxPercentage) =>
        TaxPercentage = taxPercentage;

    public decimal CalculateTotal()
    {
        var totalPrice = NumberOfItems * PricePerItem;
        var discountRate = _discountService.GetDiscountRate(totalPrice);
        var totalPriceWithDiscount = totalPrice * ((100 - discountRate) / 100);

        return totalPriceWithDiscount * ((100 + TaxPercentage) / 100);
    }
        
}