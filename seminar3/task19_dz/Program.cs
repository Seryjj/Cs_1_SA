﻿// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число :");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number>=10000 && number<=99999)
// {
// int digit1=number%10;
// int digit2=number%100/10;
// int digit4=number%10000/1000;
// int digit5=number/10000;

// if (digit1==digit5 || digit2==digit4)
// Console.WriteLine("Да");
// else Console.WriteLine("Нет");

// }
// else
// {
// Console.WriteLine("Введено не пятизначное число");

// }


﻿//разворот числа
int number = 12345; //исходное число
int tempNumber = number;//число, которое мы будем делить на 10
int reversedNumber = 0; // развернутое число
while(tempNumber > 0)
{
    int digit = tempNumber % 10;
    reversedNumber = reversedNumber * 10 + digit;
    tempNumber = tempNumber / 10;
}
if (reversedNumber=tempNumber)
Console.WriteLine("Да");
else Console.WriteLine("Нет");



