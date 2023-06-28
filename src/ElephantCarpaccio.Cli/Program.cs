using ElephantCarpaccio.Cli;

Console.WriteLine("Hello, Customer!");
Console.Write("Number of items: ");
var numberOfItemsInput = Console.ReadLine();
if (!int.TryParse(numberOfItemsInput, out int numberOfItems))
    throw new ArgumentException($"Can not parse {numberOfItemsInput} to a number");

RetailCalculator retailCalculator = new();
retailCalculator.SetNumberOfItems(numberOfItems);
retailCalculator.SetPricePerItem(1);
Console.WriteLine($"The total price, ex tax, is: {retailCalculator.CalculateTotalExcludingTax()}");