﻿// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.
int[] GetArray(int size, int leftRange,  int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    size = 16;
    return arr;
    
}

int[] arr = GetArray(5, 0, 10);
int[] copiedArray = new int[arr.Length];

for(int i = 0; i < arr.Length; i++)
{
    copiedArray[i] = arr[i];
}

Console.WriteLine($"Исходный массив = {string.Join(", ", arr)}");
Console.WriteLine($"Скопированный массив = {string.Join(", ", copiedArray)}");

// int a = 1;
// int b = a;

// a = 6;
// Console.WriteLine(a);
// Console.WriteLine(b);