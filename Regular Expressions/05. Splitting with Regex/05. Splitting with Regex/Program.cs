using System.Text.RegularExpressions;

string text = " D i d k o  -  1  9  8  1";
string pattern = @"\s+";

string[] results = Regex.Split(text, pattern);
Console.WriteLine(string.Join("", results));
