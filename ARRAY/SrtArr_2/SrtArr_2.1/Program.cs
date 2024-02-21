// Задача 2: Замена заглавных букв на строчные в строке

// Входная строка со смешанными буквами обоих регистров 
//string input = "aBcD1ef!-";
// Преобразование всех заглавных букв в строчные
void Main(string[] args)
{

    string result = input.ToLower();
    // Вывод результата
    Console.WriteLine(result);
}

//Задача 3: Проверка строки на палиндром

// Входная строка для проверки
string input = "шалаш";

// Вызов метода для проверки, является ли строка палиндромом 
bool isPalindrome = IsPalindrome(input);
{
    Console.WriteLine(isPalindrome ? "Да" : "Нет");
}
// Метод для проверки, является ли строка палиндромом
bool IsPalindrome(string str)
{
    // Нормализация строки путем удаления не буквенно-цифровых символов
    // и приведения к нижнему регистру
    string normalized = new
    string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
    // Сравнение строки с ее перевернутым вариантом
    return normalized.SequenceEqual(normalized.Reverse());
}

