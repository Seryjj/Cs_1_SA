﻿// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintBinaryView(int number)
{
    if(number <= 0) 
    {
        return;
    }
    PrintBinaryView(number / 2);
    Console.Write(number % 2);
}

int num = ReadNumber("Введите число:");
PrintBinaryView(num);
