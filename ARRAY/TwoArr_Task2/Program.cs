﻿// Назовем число “интересным” если его сумма цифр четная
// Создавать двумерный массив, состоящий из целых чисел. 
//Вывести на экран “интересные” элементы массива

int[,] CreateMatrix (int rowCount, int colomsCount)
{
int[,] matrix = new int[rowCount,colomsCount];
Random rnd = new Random();
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = rnd.Next(1, 1000);
    }
}
return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"{matrix[i,j]} "); // такой вывод называется интерполяция строк
    }
    System.Console.WriteLine();
}
}



int[,] matrix = CreateMatrix(3, 4);

ShowMatrix(matrix);

foreach (int e in matrix)
{
    if(IsInteresting(e) == true)
    {
        System.Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int SumOfDigits = GetSumOfDigits(value);

    if(SumOfDigits % 2 == 0)
    {
        return true;
    }
    //else{   сокращение кода
        return false;
   // }
}

int GetSumOfDigits(int value)
{
    int sum = 0; 
    while(value > 0)
    {
        sum = sum + value % 10; // получаем самое правое число
        value = value / 10;
    }
    return sum;
}