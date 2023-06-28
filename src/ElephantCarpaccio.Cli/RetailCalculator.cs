namespace ElephantCarpaccio.Cli;

public class RetailCalculator
{
    public int NumberOfItems { get; private set; }
    
    public void SetNumberOfItems(int numberOfItems) =>
        NumberOfItems = numberOfItems;

}