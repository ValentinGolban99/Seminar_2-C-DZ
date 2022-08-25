//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Первое решение:
// Console.WriteLine("Введите трехзначное число: ");
// string number = Convert.ToString(Console.ReadLine());

// Console.WriteLine(number[1]);

//Второе решение:
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number / 10;
int result = num % 10;
Console.WriteLine(result);

