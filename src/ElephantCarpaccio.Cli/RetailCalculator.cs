namespace ElephantCarpaccio.Cli;

public class RetailCalculator
{
    public int NumberOfItems { get; private set; }
    public decimal PricePerItem { get; private set; }
    public decimal TaxPercentage { get; private set; }
    
    public void SetNumberOfItems(int numberOfItems) =>
        NumberOfItems = numberOfItems;

    public void SetPricePerItem(decimal pricePerItem) =>
        PricePerItem = pricePerItem;
    
    public void SetTaxPercentage(decimal taxPercentage) =>
        TaxPercentage = taxPercentage;
    
    public decimal CalculateTotal() =>
        (NumberOfItems * PricePerItem) * ((100 + TaxPercentage) / 100);
}