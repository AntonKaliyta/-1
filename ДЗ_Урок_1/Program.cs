//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/* 
System.Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;
if(numberB>numberA) max = numberB;
System.Console.WriteLine($"{max} является большим числом.");
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
System.Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
System.Console.WriteLine($"{max} является наибольшим числом"); 
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
System.Console.WriteLine("Введите  число");
int number = int.Parse(Console.ReadLine());
double A = number % 2;
if (A != 0)
{
    System.Console.WriteLine($"{number} нечетное число");
}
else
{
    System.Console.WriteLine($"{number}  четное число");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

for (int i = 2; i<number+1; i= i+2)
{
    System.Console.WriteLine(i);
}