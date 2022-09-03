// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёзначное число :");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=100 && number<=999)
{
double count=number%10;
Console.WriteLine(count);

}
else
{
Console.WriteLine("Введено не трёхзначное число");

}