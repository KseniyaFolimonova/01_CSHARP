// Задание 1. Совместная работа
// Семинар 4. Функции
// 20 мин
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 3
// [4 3 4 1 9 5 21 13] => 3

bool IsPrime(int number)
{   
    if(number == 1)
    {
        return false;
    }   
    for(int i = 2; i < number; i++)
    {
        if(number % i == 0)
        {
            return false;
        }   
    }
    return true;
}

int GetCountPrimeNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i <array.Length; i++)
    {
        if(IsPrime(array[i]))
        {
            count++;
            //System.Console.Write(i + " ");
        }
    }
    return count;
}

int[] array = {4, 3, 4, 1, 9, 5, 21, 13, 2};

System.Console.WriteLine(GetCountPrimeNumbers(array));

//  for(int i = 2; i < 22; i++)
//  {
//      System.Console.WriteLine($"{i} {IsPrime(i)}");
//  }