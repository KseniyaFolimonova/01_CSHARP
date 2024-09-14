/*Задача 1: Напишите программу, которая принимает на
 вход число и проверяет, кратно ли оно одновременно
  7 и 23

int elem = 230;
if (elem % 7 == 0 && elem % 23 == 0)
{
    System.Console.WriteLine(true);
}
else
{
    System.Console.WriteLine(false);
}
задача 2. Напишите программу, которая принимает на вход координаты
точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер 
координатной четверти плоскости, в которой находится эта точка.

int x = 5;
int y = 2;
if (x > 0 && y > 0)
{
    System.Console.WriteLine("Координаты в 1 четверти");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("4");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("2");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("3");
}

Задача 3: Напишите программу, которая принимает на вход 
целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int a = 99;
int b = 0;
int d = 0;
int maxNumber = 0;

if (a > 10 && a < 99)
{
    b = a / 10;
    d = a % 10;

    if (b > d)
    {
        maxNumber = b;
    }
    else
    {
        maxNumber = d;
    }
    System.Console.WriteLine(maxNumber);
}
else
{
    System.Console.WriteLine("the number is not within the specified range");
}


//System.Console.WriteLine($"{b} {d}");

Задача 4: Напишите программу, которая на вход 
принимает натуральное число N, а на выходе 
показывает его цифры через запятую.
Решить с обратным порядком цифр, 
в эталонном решении такой вариант.

int a = 4796;
int[] array = new list[0];
int d = 0;
int b = 0;

for (int i = 0; i < a.ToString().Length, i++)
{
    b = a % 10;
    d = a / 10;
    if (d < a.ToString().Length)
    {
        a 
    }

}
System.Console.WriteLine(b);
*/
/*
Задайте одномерный массив из 10 целых чисел от 1 до 100. 
Найдите количество элементов массива, значения которых 
лежат в отрезке [10,90].

Начальные условия:

int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
Выводится: 5
*/
/*
int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] >= 10 && array[i] <= 90)
            {
                count++;

            }

        }
        System.Console.Write(count);
*/
/*
Задайте массив на 10 целых чисел. Напишите программу, 
которая определяет количество чётных чисел в массиве.

Начальные условия:

int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
Выводится: 6


int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
        int count = 0; 
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        System.Console.WriteLine(count);
*/
/*
Задайте массив из вещественных чисел с ненулевой дробной частью. 
Найдите разницу между максимальным и минимальным элементов массива.

Начальные условия:

int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
Выводится: 5.15
*/
        double[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01};
        double minElementArray = array[0];
        double maxElementArray = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minElementArray)
            {
                minElementArray = array[i];
                
            }
            else if (array[i] > maxElementArray)
            {
                maxElementArray = array[i];
                
            }
        }
        System.Console.WriteLine(maxElementArray -minElementArray);


