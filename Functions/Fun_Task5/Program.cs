// Задание 3. Совместная работа
// Семинар 4. Функции
// 20 мин
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int ConvertDigitsToNumber (int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        number += array[i] * (int)Math.Pow(10, array.Length - 1 - i);
    }
    return number;
}

int[] array = {2, 3, 1};

int num = ConvertDigitsToNumber(array);

System.Console.WriteLine(num);
