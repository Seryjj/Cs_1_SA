// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



int[] GetArray(int size, int leftRange , int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int N = ReadNumber("Задайте длину массива: ");


int[] array = GetArray(N, 100, 999);
Console.WriteLine(string.Join(", ", array));

int count=0;
   for(int i = 0; i < array.Length; i++)
    {
        if (array[i]%2== 0)
        {
            count =count+1;
        }

    }
    Console.WriteLine(count);