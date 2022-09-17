// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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


int[] array = GetArray(N,-1000000,1000000);
Console.WriteLine(string.Join(", ", array));

int sum=0;
   for(int i = 0; i < array.Length; i++)
    {
        if (i%2== 1)
        {
            sum =sum+array[i];
        }

    }
    Console.WriteLine(sum);