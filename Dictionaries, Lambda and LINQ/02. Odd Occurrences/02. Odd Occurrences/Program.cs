string[] words = Console.ReadLine().Split(" ");

Dictionary<string, int> wordsCount = new();

foreach (string word in words)
{
    string caseInsenstiveWords = word.ToLower();

    if (wordsCount.ContainsKey(caseInsenstiveWords))
    {
        wordsCount[caseInsenstiveWords] += 1;
    }
    else
    {
        wordsCount.Add(caseInsenstiveWords, 1); 
    }
}
foreach (var pair in wordsCount)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");    
    }
}
