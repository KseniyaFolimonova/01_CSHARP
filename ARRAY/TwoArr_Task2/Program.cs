﻿﻿// Считать с консоли строку, состоящую из цифр и латинских букв.
//Сформировать новую строку, состоящую из букв исходной строки.

string GetLettersFromString(string s)
{
    string letters = "";
    foreach(char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
System.Console.WriteLine(GetLettersFromString(str));