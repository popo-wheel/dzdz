﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("M = ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("N = ");
int num2 = Convert.ToInt32(Console.ReadLine());

int FindDistBetwFrstScnd(int num1, int num2)
{

  if (num1 == num2) return num2;
  else return num1 + FindDistBetwFrstScnd(num1+1,num2);

}


if (num1 < num2)
Console.WriteLine($"-> {FindDistBetwFrstScnd(num1,num2)}");
if (num1 > num2)
Console.WriteLine($"-> {FindDistBetwFrstScnd(num2,num1)}");