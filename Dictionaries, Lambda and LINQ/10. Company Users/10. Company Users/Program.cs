Dictionary<string, List<string>> comapnies = new();

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputArray = input.Split(" -> ");
    string company = inputArray[0];
    string emploeeID = inputArray[1];

    if (!comapnies.ContainsKey(company))
    {
        comapnies.Add(company, new List<string>());
    }
    if (!comapnies[company].Contains(emploeeID))
    {
        comapnies[company].Add(emploeeID);
    }
    input = Console.ReadLine();
}

foreach (KeyValuePair<string, List<string>> currentCompany in comapnies)
{
    Console.WriteLine(currentCompany.Key);

    foreach (string curentEmploeedID in currentCompany.Value)
    {
        Console.WriteLine($"-- {curentEmploeedID} ");
    }
}
