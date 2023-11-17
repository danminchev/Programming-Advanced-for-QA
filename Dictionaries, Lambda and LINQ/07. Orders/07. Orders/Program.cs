Dictionary<string, List<decimal>> products = new();

string input = Console.ReadLine();

while (input != "buy")
{
    string[] inputArray = input.Split();
    string product = inputArray[0];
    decimal price = decimal.Parse(inputArray[1]);
    decimal quantity = decimal.Parse(inputArray[2]);

    if (!products.ContainsKey(product))
    {
        products.Add(product, new List<decimal>());
        products[product].Add(price);
        products[product].Add(quantity);
    }
    else
    {
        products[product][0] = price;
        products[product][1] += quantity;
    }
    input = Console.ReadLine();
}
foreach (KeyValuePair<string, List<decimal>> currentProduct in products)
{
    string currentProductName = currentProduct.Key;
    decimal currentProductPrice = currentProduct.Value[0];
    decimal currentProdcutQuantity = currentProduct.Value[1];

    decimal currebtProductAmount = currentProductPrice * currentProdcutQuantity;

    Console.WriteLine($"{currentProductName} -> {currebtProductAmount:F2}");
}

