/*
Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива.

В этом коде создается двумерный массив символов charArray, 
затем используется метод GetStringFromCharArray для преобразования 
этого массива в строку. Функция GetStringFromCharArray использует 
StringBuilder для эффективной конкатенации символов. 
Результат выводится на консоль.


char[,] charArray = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'},
            {'g', 'h', 'i'}
        };

// Создаем строку из символов массива
string resultString = GetStringFromCharArray(charArray);

// Выводим результат
Console.WriteLine(resultString);


    static string GetStringFromCharArray(char[,] charArray)
{
    // Получаем размеры массива
    int rowCount = charArray.GetLength(0);
    int colCount = charArray.GetLength(1);

    // Инициализируем объект StringBuilder для эффективной работы со строками
    System.Text.StringBuilder resultBuilder = new System.Text.StringBuilder();

    // Обходим массив символов и добавляем каждый символ в строку
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < colCount; j++)
        {
            resultBuilder.Append(charArray[i, j]);
        }
    }

    // Возвращаем строку
    return resultBuilder.ToString();
}
*/

// Инициализация двумерного массива символов
char[,] charArray = new char[,] { 
    { 'a', 'b' }, 
    { 'c', 'd' },
    { 'e', 'f' } 
    };
// Вызов метода для создания строки из массива
string result = CreateStringFromArray(charArray);
// Вывод результата
Console.WriteLine(result);

// Метод для создания строки из двумерного массива символов
string CreateStringFromArray(char[,] array)
{
    string result = "";
    // Цикл по каждому элементу в двумерном массиве
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // Добавление каждого символа в результирующую строку
            result += array[i, j];
        }
    }
    return result;
}


