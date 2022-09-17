// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



int[]array = {3,7,22,2,78};


Console.WriteLine(string.Join(", ", array));

int max=array[0];
   for(int i = 0; i < array.Length; i++)
    {
        if (max<array[i])
        {
            max=array[i];
        }

    }

int min=array[0];
   for(int i = 0; i < array.Length; i++)
    {
        if (min>array[i])
        {
            min=array[i];
        }

    }


    Console.WriteLine(max-min);