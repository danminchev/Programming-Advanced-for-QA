using System.Text.RegularExpressions;

string text = "Didko: 1981";
string pattern = @"([A-Za-z]+): (\d+)";

Regex regex = new Regex(pattern);
Match match = regex.Match(text);

Console.WriteLine(match.Groups.Count);
Console.WriteLine("Mached text: \"{0}\"", match.Groups[0]);
Console.WriteLine("Name : {0}", match.Groups[1]);
Console.WriteLine("Number : {0}", match.Groups[2]);

