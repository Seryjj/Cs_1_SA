﻿// Задача 32: Напишите программу замена элементов 
// массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int size, int leftRange, int rightRange)
{
    
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void SwapSigns(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", array));
SwapSigns(array);
Console.WriteLine(string.Join(", ", array));