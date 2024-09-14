/*
Задача 3: Задайте произвольный массив. Выведете его элементы, 
начиная с конца. Использовать рекурсию, не использовать циклы.
*/
void ArrayReversed(int[] array, int i)
{
    if (i >= 0)
    {
        System.Console.Write(array[i] + " ");
        ArrayReversed(array, i - 1);
    }
}

int[] array = { 1, 2, 3, 4, 5};

System.Console.WriteLine("Реверсивный массив");
ArrayReversed(array, array.Length - 1);