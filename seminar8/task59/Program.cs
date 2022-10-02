﻿//task 59
int[,] DeleteIntersectionByMinElement(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int minElement = matrix[0, 0];//мин элемент
    int minRow = 0;//индекс строки с мин элементом
    int minColumn = 0;//индекс столбца с мин элементом

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement) //поиск минимального элемента
            {
                minElement = matrix[i, j];//минимальный элемент
                minRow = i;//индекс строки
                minColumn = j;//индекс столбца
            }
        }
    }

    int rowOffset = 0;//смещение для исходной матрицы по строке
    int columnOffset = 0;//смещение для исходной матрицы по столбцу

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == minRow) rowOffset++;//если лишняя строка -> смещение = 1, иначе = 0
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == minColumn) columnOffset++;//если лишний столбец -> смещение = 1, иначе = 0
            newMatrix[i,j] = matrix[i + rowOffset, j + columnOffset];//записать в новую матрицу данные из старой с учетом всех смещений
        }
        columnOffset = 0;//обнулить смещение по столбцу
    }
    return newMatrix;
}


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
Console.WriteLine("\n");
int[,] newMatr = DeleteIntersectionByMinElement(matr);
PrintMatrix(newMatr);