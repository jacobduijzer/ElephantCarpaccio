using ElephantCarpaccio.Cli;

bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

static bool MainMenu()
{
    Console.Clear();
    Console.WriteLine("Hello, Customer!");
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1) Calculate retail price");
    Console.WriteLine("2) Exit");
    Console.Write("\r\nSelect an option: ");
 
    switch (Console.ReadLine())
    {
        case "1":
            CalculateRetailPrice();
            return true;
        
        default:
            return false;
    }
}

static void CalculateRetailPrice()
{
    Console.Write("Number of items: ");
    var numberOfItemsInput = Console.ReadLine();
    if (!int.TryParse(numberOfItemsInput, out int numberOfItems))
        throw new ArgumentException($"Can not parse {numberOfItemsInput} to a number");

    Console.Write("Price per item: ");
    var pricePerItemString = Console.ReadLine();
    if (!decimal.TryParse(pricePerItemString, out decimal pricePerItem))
        throw new ArgumentException($"Can not parse {pricePerItemString} to a number");

    Console.Write("State (for tax): ");
    var stateForTax = Console.ReadLine();
    var taxPercentage = new TaxService().GetPercentageForState(stateForTax);

    Console.WriteLine($"Tax percentage for state '{stateForTax}': {taxPercentage}%");
    RetailCalculator retailCalculator = new(new DiscountService());
    retailCalculator.SetNumberOfItems(numberOfItems);
    retailCalculator.SetPricePerItem(pricePerItem);
    retailCalculator.SetTaxPercentage(taxPercentage);

    Console.WriteLine($"The total price is: {retailCalculator.CalculateTotal()}");
    Console.WriteLine("Press enter to continue");
    Console.ReadLine();
}
