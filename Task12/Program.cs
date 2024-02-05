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
*/
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