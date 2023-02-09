System.Console.Write("Введите число ");
// Варианты написания: 2 либо 3 строка
//int number = Convert.ToInt32(Console.ReadLine());
int number = int.Parse(Console.ReadLine());

int sqr = number * number;
// Варианты написания 8 либо 9 строка
// System.Console.Write("Квадрат числа " + number + "равен " + sqr);
System.Console.Write($"Квадрат числа {number} равен {sqr}");

// можно сразу в обход 6 строки написать System.Console.Write($"Квадрат числа {number*number} ");
