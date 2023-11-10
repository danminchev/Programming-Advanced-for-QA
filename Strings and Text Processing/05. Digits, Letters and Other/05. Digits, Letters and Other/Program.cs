using System.Text;

string text = Console.ReadLine();

StringBuilder digits = new StringBuilder();
StringBuilder letters = new StringBuilder();
StringBuilder otherSymbols = new StringBuilder();

foreach (char symbol in text)
{
    if (char.IsDigit(symbol))
    {
        digits.Append(symbol);
    }
    else if (char.IsLetter(symbol))
    {
        letters.Append(symbol);
    }
    else
    {
        otherSymbols.Append(symbol);
    }
}
Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(otherSymbols);
