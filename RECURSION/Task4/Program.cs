/* Задание 4.
Считать строку с консоли, содержащую латинские буквы.
Вывести на экран согласные буквы этой строки.
*/
bool IsLetter(char ch)
{
    return (('a' <= ch && 'z' >= ch) || ('A' <= ch && 'Z' >= ch));
}

bool IsVowels(char ch)
{
    string vowels = "aeyuioAEYUIO";
    for (int i = 0; i < vowels.Length; i++)
    {
        if (ch == vowels[i])
        {
            return true;
        }
    }
    return false;
}

void PrintConsonants(string word, int i = 0)
{
    if (i >= word.Length)
    {
        return;
    }

    //string vowels = "aeyuio";
    //if (char.IsLetter(word[i]) && !vowels.Contains(word[i]))
    if (IsLetter(word[i]) && !IsVowels(word[i]))
    {
        System.Console.Write(word[i] + " ");
    }
    PrintConsonants(word, i + 1);
}

PrintConsonants("kjhfqeihj4nb;nHGIUCVIYCI");