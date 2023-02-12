//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от 1 до 7");

string day = Console.ReadLine();

int day_number;
int.TryParse(day, out day_number);

if (5 < day_number && day_number <= 7) //if (day_number == 6 || day_nuber == 7)
    Console.WriteLine($"{day} -> да");
else
    Console.WriteLine("нет");

