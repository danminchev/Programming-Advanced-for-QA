string remuveString = Console.ReadLine();
string textToRemuve = Console.ReadLine();

while (textToRemuve.Contains(remuveString))
{
    textToRemuve = textToRemuve.Replace(remuveString, string.Empty);
}

Console.WriteLine(textToRemuve);
   


