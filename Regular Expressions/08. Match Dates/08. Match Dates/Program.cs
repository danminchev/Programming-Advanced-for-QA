using System.Text.RegularExpressions;

string pattern = @"\b(?<day>\d{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b";

Regex regex = new Regex(pattern);

string text = Console.ReadLine();

MatchCollection matches = regex.Matches(text);

foreach (Match match in matches)
{
    Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
}
