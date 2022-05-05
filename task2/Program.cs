// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.WriteLine(" Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A < B + C & B < A + C & C < A + B)
Console.WriteLine("Является треугольником!");
else
Console.WriteLine("Не является трекгольником!");