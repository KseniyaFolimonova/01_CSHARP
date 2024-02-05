double CalculeteFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;

}
double result = CalculeteFormula(1, 2, 3, 4);
System.Console.WriteLine(result);