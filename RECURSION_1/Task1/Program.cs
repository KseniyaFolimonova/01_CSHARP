/*
void OpenMatryoshka(int size)
{
    if(size == 1)
    {
        return;
    }
    OpenMatryoshka(size - 1);
    System.Console.WriteLine($"Opening Matryoshka of size {size}...");
    
}
OpenMatryoshka(5);
*/

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        System.Console.WriteLine($"Stop: {n}");
        return 1;
    }
    System.Console.WriteLine(n);
    return n * Fact(n-1);
}
System.Console.WriteLine(Fact(5));
// F11  шаг с заходом 
// F10 шаг с обходом
// F5 продолжить (до следующей точки)