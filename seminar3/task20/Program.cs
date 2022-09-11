﻿// Задача 20: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// AB = √((xb - xa)^2 + (yb - ya)^2)

Console.WriteLine("Введите координату точки A по X");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки A по Y");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по X");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по Y");
int yb = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
Console.WriteLine($"{res:f2}");

