﻿// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер координатной четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter >= 1 && quarter <= 4) //проверка на правильность ввода четверти
{
    if (quarter == 1)
    {
        Console.WriteLine("x > 0 && y > 0");
    }
    if (quarter == 2)
    {
        Console.WriteLine("x < 0 && y > 0");
    }
    if (quarter == 3)
    {
        Console.WriteLine("x < 0 && y < 0");
    }
    if (quarter == 4)
    {
        Console.WriteLine("x > 0 && y < 0");
    }
}
else
{
    Console.WriteLine("Существуют только 4 координатные четверти");
}
// double number = 25;
// number = Math.Sqrt(number);
// Console.WriteLine(number);