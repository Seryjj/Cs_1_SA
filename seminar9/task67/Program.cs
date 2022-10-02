﻿// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int number)
{
    if(number == 0) return 0;
    else
    {
        return number % 10 + SumDigits(number / 10);
    }
}

Console.WriteLine(SumDigits(ReadNumber("Введите M")));