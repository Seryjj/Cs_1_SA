// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



Console.WriteLine("Введите число для дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if(number>=1 && number<=7)

{
    if (number==6 || number==7)
    Console.WriteLine("Да");

    else 
    Console.WriteLine("Нет");
}

else
{
 Console.WriteLine("Не введёна цифра, обозначаюшую день недели");
}