System.Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите квадрат числа");
int number2 = int.Parse(Console.ReadLine());

if (number1 * number1 == number2)
{
    System.Console.WriteLine($"{number1} является корнем числа {number2}");
}
else
{
    System.Console.WriteLine($"{number1} не является корнем числа {number2}");
}