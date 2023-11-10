string word = Console.ReadLine();

while (word != "end")
{
    //char[] wordCharsArray = word.ToCharArray();
    //Array.Reverse(wordCharsArray);
    //string reversedWord = string.Join("", wordCharsArray);

    string reversedWord = string.Join("", word.ToCharArray().Reverse());

    Console.WriteLine($"{word} = {reversedWord}");

    word = Console.ReadLine();
}

