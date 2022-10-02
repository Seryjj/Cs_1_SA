﻿int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintMtoN(int m, int n)
{
    if(n < m)
    {
        if (m == n - 1)
        {
            return;
        }
        Console.Write(m + " ");
        PrintMtoN(m - 1, n);
    }
    else if(n > m)
    {
        if(n == m - 1)
        {
            return;
        }
        PrintMtoN(m, n - 1);
        Console.Write(n + " ");
    }
    else if(n == m) Console.Write(n + " ");
}

int M = ReadNumber("Введите M");
int N = ReadNumber("Введите N");

PrintMtoN(M, N);
