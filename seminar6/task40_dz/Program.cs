// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// ( НЕОБЯЗАТЕЛЬНАЯ)



int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int a = ReadNumber("Введите число a:");
int b = ReadNumber("Введите число b:");
int c = ReadNumber("Введите число c:");
if (a<b+c && b<a+c && c<a+b)
    Console.Write("Треугольник существует");
else Console.Write("Треугольник не существует");