/*Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да

int[] arr = { 1, 3, 4, 19, 3 };
int a = 8;
bool inArray = false;

for (int i = 0; i < arr.Length; i++)
{
    if (a == arr[i])
        inArray = true;
}
System.Console.WriteLine(inArray);
*/

int[] arr = { 1, 3, 4, 19, 3 };
int j = 8;

foreach(int e in arr)
{
    if(j == e)
    {
        Console.WriteLine(true);
        return; // Завершаем выполнение метода или блока кода
    }
}

Console.WriteLine(false);

/*
int[] arr = {1, 3, 4, 19, 3};
int a = 8;
bool inArray = false;

/*for(int i = 0; i<arr.Length;i++)
{
    if(a == arr[i])
    {
        inArray = true;
        //System.Console.WriteLine("Да");
    }
    
}

foreach(int i in arr)
{
    if(a == i)
    {
        inArray = true;
    }
}

if(inArray)
{
    System.Console.WriteLine("Да");
}
else
{
*/