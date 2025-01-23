/* Задача 2.
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
*/
void RangeOfDigits(int n, int m = 1)
{
    if (m == n)
    {
        System.Console.Write(n);
        return;
    }
    System.Console.Write(m + " ");
    RangeOfDigits(n, m + 1);
}
int n = 7;
RangeOfDigits(n);