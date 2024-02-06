
/*Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]

int[] array = { -1, 5, -6};

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
        array[i] = array[i]* (-1);
}
System.Console.WriteLine($"{array[i]} ");

int [] a ={1,-5,-6};
for (int i = 0; i < a.Length; i++)
{
    a[i] = a[i]*(-1);
}
for (int i = 0; i < a.Length; i++)
{
    System.Console.Write($"{a[i]} ");
}
*/
/*
Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/

int[] array = { 1, 3, 2, 4, 2, 3, 18 };
int[] result = new int[array.Length / 2];
int middleIndexArray = 0;
int middleElementArray = 0;

if (array.Length % 2 != 0)
    {
       middleIndexArray = array.Length / 2;
       middleElementArray = array[array.Length / 2];
       System.Console.WriteLine(middleElementArray + " The Element dosn`t have a pair");
    }
    for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
    {

    
    result[i] = array[i] * array[j];

    Console.Write($"{result[i]} ");
    }
/*
int[] array = { 1, 3, 2, 4, 2, 3 };
int[] result = new int[array.Length / 2];

for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
{
    result[i] = array[i] * array[j];
    Console.Write($"{result[i]} ");
}
*/
/* Домашка 1
Задача 1
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в диапазон [10, 90]
    // array уже есть
    public static void PrintResult(int[] array)
    {
          // считаем количество 10 <= array[i] <= 90
          Console.WriteLine();
    }

}
Домашка 2
Задача 2
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива  
    public static void PrintResult(int[] array)
    {
        //Напишите свое решение здесь
        Concole.WriteLine();
    }
}
Задача 3
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
      
    public static void PrintResult(double[] array)
    {
        // Напишите свое решение здесь
        double min = array[0];
        // max ...
        // Console.WriteLine(result);
    }
}
*/