﻿// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountOfDigits(int num)
{
    int count = 0; //число цифр (количество итераций цикла)
    if (num == 0) count = 1;
    while(num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int number = ReadNumber("Введите число:");
int count = GetCountOfDigits(number);
Console.WriteLine(count);
