//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Первое решение:
// Console.WriteLine("Введите трехзначное число: ");
// string number = Convert.ToString(Console.ReadLine());

// Console.WriteLine(number[1]);

// Основное решение:
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number / 10;
int result = num % 10;
Console.WriteLine("Вторая цифра числа " + number + " - это " + result);

// Дополнительно:
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string numberText = Convert.ToString(number);
// if (numberText.Length == 3)
// {
//     Console.WriteLine("Вторая цифра числа " + number + " - это " + numberText[1]);
// }
// else
// {
//     Console.WriteLine("Введенное число не является трехзначным");
// }

