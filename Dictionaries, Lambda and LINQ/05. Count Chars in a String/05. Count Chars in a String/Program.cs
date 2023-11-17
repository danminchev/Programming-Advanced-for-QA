string input = Console.ReadLine();

Dictionary<char, int> charOccurrences = new();

foreach (char ch in input)
{
    if (ch == ' ')
    {
        continue;
    }
    if (!charOccurrences.ContainsKey(ch))
    {
        charOccurrences.Add(ch, 1);
    }
    else
    {
        charOccurrences[ch]++;
    }
}

foreach (KeyValuePair<char, int> pair in charOccurrences)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}


