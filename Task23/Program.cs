/* Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

 
using System;
using static System.Console;


WriteLine("Введите число: ");
double N = double.Parse(ReadLine());

Write($"{N} -> ");
for(double i = 1; i <= N; i++) 
{
    Write($"{Math.Pow(i, 3)}{(i != N ? "," : "\n")}");
} 