﻿using System;

namespace TestApp;

public class TextFilter
{
    public static string Filter(string[] bannedWords, string text)
    {
        foreach (string word in bannedWords)
        {
            if (text.Contains(word))
            {
                text = text.Replace(word, new string('*', word.Length));
            }
        }

        return text;
    }

    public static string[] Filter(string[] bannedWord, string[] text)
    {
        throw new NotImplementedException();
    }
}
