string ExtractDigits(string input)
{
    SrtingBuilder digits  = new SrtingBuilder(); //создает новый объект типа StringBuilder, который будет использоваться для построения строки, содержащей цифры из введенной строки.
    foreach(char character in input)
    {
        if(char.IsDigit(character))
        {
            digits.Append(character);
        }
    }
    return digits.ToString();
}


Console.Write("Введите чтроку с числами и символами:");
string inputString = Console.ReadLine();
System.Console.Write(ExtractDigits(inputString));

