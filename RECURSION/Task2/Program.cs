/* Задача 1.
Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр
*/
int SumOfDigits(int numbers)
{
    
    if (numbers == 0)
    {
       // Console.WriteLine("End = 0")
        return 0;
    }
    return numbers % 10 + SumOfDigits(numbers / 10);
    // int sum1 = numbers % 10;
    // Console.WriteLine($"({numbers}) sum1 = {sum1}");
    // int sum2 = SumOfDigits(numbers / 10);
    // Console.WriteLine($"({numbers}) sum2 = {sum2}");
    // int sum = sum1 + sum2;
    // Console.WriteLine($"({numbers}) sum = {sum}");
    // return sum;
}

int numbers = 1234;
int sum = SumOfDigits(numbers);
System.Console.WriteLine(sum);