/*
double CalculeteFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;

}
double result = CalculeteFormula(1, 2, 3, 4);
System.Console.WriteLine(result);
*/
void PrintSqueres (int limit)
{
    int i = 1;
    while (i <= limit)
    {
        System.Console.Write($"{i * i} ");
        i++;
    }
}

PrintSqueres(5);
PrintSqueres(10);
PrintSqueres(15);
