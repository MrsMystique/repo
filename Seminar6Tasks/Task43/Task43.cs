/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();
Console.WriteLine("Введите первую координату K1: ");
int CordK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату B1: ");
int CordB1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую координату K2: ");
int CordK2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату B2: ");
int CordB2 = Convert.ToInt32(Console.ReadLine());

float y;
float x;
x = (CordB2-CordB1) / (float)(CordK1-CordK2);
y = (float) CordK1*x + CordB1;

Console.WriteLine($"Точка пересечения по y = {y}, и по х = {x}");
