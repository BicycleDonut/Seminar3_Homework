﻿// Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите число x1   ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y1   ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число z1   ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число x2   ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число y2   ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число z2   ");
double z2 = Convert.ToDouble(Console.ReadLine());
double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+Math.Pow(z2-z1,2));
Console.WriteLine(length);