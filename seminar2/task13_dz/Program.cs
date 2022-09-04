// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

int i=0;
int num=number;


    while(num > 0)
    {
        num = num / 10;
        i=i+1;
    }

if (i>=3)
{
     double l=number/(Math.Pow(10, i-3));
     int digit3=(int)l%10;
    Console.WriteLine(digit3);

}
else
{
 Console.WriteLine("третьей цифры нет");
}
