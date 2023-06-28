using ElephantCarpaccio.Cli;

Console.WriteLine("Hello, Customer!");
Console.Write("Number of items: ");
var numberOfItemsInput = Console.ReadLine();
if (!int.TryParse(numberOfItemsInput, out int numberOfItems))
    throw new ArgumentException($"Can not parse {numberOfItemsInput} to a number");

Console.Write("Price per item: ");
var pricePerItemString = Console.ReadLine();
if (!decimal.TryParse(pricePerItemString, out decimal pricePerItem))
    throw new ArgumentException($"Can not parse {pricePerItemString} to a number");

RetailCalculator retailCalculator = new();
retailCalculator.SetNumberOfItems(numberOfItems);
retailCalculator.SetPricePerItem(pricePerItem);
Console.WriteLine($"The total price is: {retailCalculator.CalculateTotal()}");