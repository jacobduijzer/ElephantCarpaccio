namespace ElephantCarpaccio.Cli;

public class RetailCalculator
{
    private const decimal _tax = 6.85m;
    public int NumberOfItems { get; private set; }
    
    public decimal PricePerItem { get; private set; }
    
    public void SetNumberOfItems(int numberOfItems) =>
        NumberOfItems = numberOfItems;

    public void SetPricePerItem(decimal pricePerItem) =>
        PricePerItem = pricePerItem;

    public decimal CalculateTotal() =>
        (NumberOfItems * PricePerItem) * ((100 + _tax) / 100);
}