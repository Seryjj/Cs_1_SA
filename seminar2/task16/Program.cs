// Напишите программу, которая на вход принимает два числа и проверяет, является ли одно число квадратом другого


Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB * numberB==numberA || numberA * numberA==numberB)
{

Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
