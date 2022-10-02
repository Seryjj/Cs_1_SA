// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7




void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int l = 0; l < n * n; l++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        i=i+1;
        j=j+1;
        n = n < 2 ? 0 : n - 2;
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write(array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int razmer = 4;
int[,] table = new int[razmer, razmer];
FillArraySpiral(table, razmer);
PrintArray(table);
