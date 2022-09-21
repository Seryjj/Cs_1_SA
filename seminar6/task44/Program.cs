﻿// Задача 44: Не используя рекурсию, 
// выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintFiboToN(int n)
{
    if(n >= 2)
    {
        int[] fibo = new int[n];
        fibo[0] = 0;
        fibo[1] = 1;
        for(int i = 2; i < fibo.Length; i++)
        {
            fibo[i] = fibo[i - 1] + fibo[i - 2];
        }
        Console.WriteLine(string.Join(" ", fibo));
    }
    else
    {
        Console.WriteLine("N должно быть не меньше 2");
    }
}

int number = ReadNumber("Введите N");
PrintFiboToN(number);