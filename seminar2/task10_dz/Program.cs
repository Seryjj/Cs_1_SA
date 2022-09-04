// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите трёзначное число :");
int number = Convert.ToInt32(Console.ReadLine());

if (number>=100 && number<=999)
{
int digit2=number/10%10;
Console.WriteLine(digit2);

}
else
{
Console.WriteLine("Введено не трёхзначное число");

}











