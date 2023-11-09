using System.Text.RegularExpressions;

string text = "Didko: 1981, ProgrammingQA: 2023";
string pattern = @"([A-Za-z]+): (\d+)";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(text);

Console.WriteLine("Found {0}", matches.Count);

foreach (Match match in matches)
{
    Console.WriteLine("Name: {0}", match.Groups[1]);
}