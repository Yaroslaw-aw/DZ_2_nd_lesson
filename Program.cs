// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.WriteLine("Введите число");

string string_number = Console.ReadLine();

if (string_number.Length >= 3)
    Console.WriteLine(string_number[2]);
else
    Console.WriteLine("третьей цифры нет");
