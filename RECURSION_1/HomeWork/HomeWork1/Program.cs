/*
Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/
// Вводим значения M и N

void PrintNumbersInRange(int start, int end)
{
    if (start > end)
    {
        return;
        System.Console.WriteLine($"Число {start} больше N");
        
    }
    Console.WriteLine($"{start} ");

    PrintNumbersInRange(start + 1, end);
}

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
//int m = 12;
//int n = 7;

PrintNumbersInRange(m, n);

