﻿// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел 
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbersFrom1ToA(int a)
{
    if (a >= 1) //если А больше либо равно 1, то работаем дальше
    {
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            sum = sum + i; //копим сумму
            //sum += i; //альтернативный вариант записи команды выше
        }
        return sum; //вернем накопившуюся сумму
    }
    else
    {
        Console.WriteLine("A должна быть не меньше 1!");
        return -1; //неправильная сумма (код ошибки)
    }
}

int number = ReadNumber("Введите число :");
int sum = SumNumbersFrom1ToA(number);
Console.WriteLine($"Сумма элементов от 1 до A = {sum}");



