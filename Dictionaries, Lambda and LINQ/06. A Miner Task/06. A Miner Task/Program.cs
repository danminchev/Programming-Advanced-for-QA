Dictionary<string, int> colectResources = new Dictionary<string, int>();

string resource = Console.ReadLine();

while (resource != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

    if (!colectResources.ContainsKey(resource))
    {
        colectResources.Add(resource, quantity);
    }
    else
    {
        colectResources[resource] += quantity;
    }

    resource = Console.ReadLine();
}

foreach (KeyValuePair<string, int> pair in colectResources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}

