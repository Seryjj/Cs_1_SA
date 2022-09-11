﻿

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ProdNumbersFrom1ToA(int a)
{
    if (a >= 1) //если А больше либо равно 1, то работаем дальше
    {
        int sum = 1;
        for (int i = 2; i <= a; i++)
        {
            sum = sum * i; //копим произведение
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
int sum = ProdNumbersFrom1ToA(number);
Console.WriteLine($"Произведение элементов от 1 до A = {sum}");