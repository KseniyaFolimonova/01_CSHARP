// Напишите программу, которая принимает на вход
//трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа.
//456 => 10
//782 => 9
//918 => 17
/*
int number = 789;
int FirstDigit = number /100;
int LastDigit = number % 10;

System.Console.WriteLine(FirstDigit + LastDigit);
*/
/*
     int firstNumber = 3;
     int secondNumber = 3;

     if (firstNumber < secondNumber)
     {
         Console.WriteLine("второе число больше");
     }
     else if (firstNumber > secondNumber)
     {
         Console.WriteLine("первое число больше");
     }
     else
     {
         System.Console.WriteLine("числа равны");
     }
     */
/*
int a = 5;
int b = 6;
int c = 7;
int FindMax = 0;

if (a > FindMax)
{
    FindMax = a;
}
else if (b > FindMax)
{
    FindMax = b;
}
else if (c > FindMax)
{
    FindMax = c;
}
return (FindMax);


        int number = 3;
        if (number % 2 == 0)
        {
            System.Console.WriteLine("четное");
        }
        else
        {
            System.Console.WriteLine("нечетное");
        }

        int number = 8;
        int i = 1;
        while (i <= number)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
            i += 1;
        }

int a = 1;
int b = 6;
int c = 7;
int FindMax = Math.Max(Math.Max(b, c), a);

return FindMax;
*/
int a = 1;
int b = 6;
int c = 7;
FindMax = 0;

if (a > b & a > c)
{
    FindMax = a;
    return FindMax;
}
else if (b > a & b > c)
{
    FindMax = b;
    return FindMax;
}
else
{
    FindMax = c;
    return FindMax;
}