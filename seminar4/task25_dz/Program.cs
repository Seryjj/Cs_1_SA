// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int fun2(int a, int b)
{
        int step = a;
        for (int i = 1; i < b; i++)
        {
            step = step*a; 
     
        }
        return step;
}
int a= ReadNumber("Введите число A:");
int b= ReadNumber("Введите число B:");
int step = fun2(a, b);
Console.WriteLine(step);


