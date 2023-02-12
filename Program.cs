// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");

string string_number = Console.ReadLine();
int number;
int.TryParse(string_number, out number);

int second_number = number / 10 % 10;

Console.WriteLine(second_number);
