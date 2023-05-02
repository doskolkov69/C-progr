// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Random = new Random().Next(100,1000);
Console.WriteLine(Random);

int first = (Random / 10) % 10;

Console.WriteLine($"{first}");