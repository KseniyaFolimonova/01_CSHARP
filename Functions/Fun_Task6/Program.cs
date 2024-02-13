/*Задача 1: Напишите программу, которая бесконечно запрашивает 
целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, 
сумма цифр которого чётная.

while (true)
{
    Console.Write("Введите число или 'q' для выхода: ");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    int number;
    int sum = 0;
    if (int.TryParse(input, out number))
    {
        System.Console.WriteLine(number);;
    }
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    if (sum % 2 == 0)
    {
        Console.WriteLine("[STOP]");
        break;
    }

    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
    }
}
*/
/*
*Задача 2: Подсчет количества четных чисел в массиве
using System;

int[] array = GetRandomArray(10, 1, 100);
PrintArray(array);

int[] GetRandomArray(int size, int minValue, int maxValue)
{
Random rnd = new Random();
int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = rnd.Next(int minValue, int maxValue);
   
    }
    return array;
}
void PrintArray(int[] array)
{
    if (array[i] % 2 == 0)
    {
        evenCount++;
    }
}
System.Console.Write(evenCount + " ");
}

*/
/*
Задача 3: Реверсирование одномерного массива
using System;
class Program
*/
int[] array = GetReversArray {1,4,12,78,5,46,9};
PrintArray(array);

void GetReversArray(int array)
{
int temp = 0;
for(int i = 0, j = array.Length - 1; i < array.Length/2; i++, j--)
{
    temp = array[i];
    array[i] = array[j];
    array[j] = temp;
}

System.Console.Write("Reversed array: ");
}
void PrintArray(int array)
{
foreach (int item in array)
{
    System.Console.Write(item + " ");
}
}