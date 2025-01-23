/*
// Задание 1. Совместная работа
// Семинар 5. Двумерные массивы
// 15 мин
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
//  4 3 4 1 =>
//  2 9 5 4

// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

void ChangeArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i %2 == 0 && j %2 == 0 && i == j)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
} 

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i, j],-4}");
            Console.Write($"{matrix[i, j]:d2}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] matrix =
{
    {2, 3, 4, 3, 4},
    {1, 7, 9, 10, 5},
    {6, 4, 5, 1, 7}
};
PrintMatrix(matrix);
ChangeArray(matrix);
PrintMatrix(matrix);
*/

void ChangeArray (int[,] matrix)
{
    for ( int i =0; i < matrix.GetLength(0); i++)
    {
        for(int j =0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 ==0 && j % 2 ==0)
            {
                matrix[i,j] *= matrix[i,j]; 
            }
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i, j],-4}"); с выводом 4 знаков
            Console.Write($"{matrix[i, j]:d2}  "); // с выводом 2 знаков с ведущими нулями
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] matrix =
{
    {2, 3, 4, 3, 4},
    {1, 7, 9, 10, 5},
    {6, 4, 5, 1, 7}
};
PrintMatrix(matrix);
ChangeArray(matrix);
PrintMatrix(matrix);