using System.Text.RegularExpressions;

string text = "Didko: 1981, ProgrammingQA: 2023";
string pattern = @"\d{4}";
string replacemend = "9999";

Regex regex = new Regex(pattern);
string result = regex.Replace(text, replacemend);

Console.WriteLine(result);
