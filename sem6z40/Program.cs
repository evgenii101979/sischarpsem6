// Задача 40: Напишите программу, которая принимает на вход 
//три числа и проверяет, может ли существовать треугольник с 
//сторонами такой длины.	Теорема о неравенстве треугольника: 
//каждая сторона треугольника меньше суммы двух других сторон.

/*Console.WriteLine("Введите первое число: ");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);
Console.WriteLine("Введите первое число: ");
string b = Console.ReadLine();
int b1 = Convert.ToInt32(b);
Console.WriteLine("Введите первое число: ");
string c = Console.ReadLine();
int c1 = Convert.ToInt32(c);

if (a1 + b1 >= c1 && a1 + c1 >= b1 && b1 + c1 >= a1)
{
    Console.WriteLine($"треугольник может существовать");
}
else
{
    Console.WriteLine($"бред");
}*/

//Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.

using System;

Console.WriteLine("\nВведите сторону a: ");
int side_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nВведите сторону b: ");
int side_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nВведите сторону c: ");
int side_c = Convert.ToInt32(Console.ReadLine());

int max = 0;

max = (side_a >= side_b) ? side_a : 0;
max = (max <= side_c) ? side_c : 0;
string output = (max < (side_a + side_b)) ? "Треугольник существует" : "Треугольник не существует";

Console.WriteLine(output);
