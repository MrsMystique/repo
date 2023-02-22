﻿//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

   
Console.Write("Введите количество строк треугольника Паскаля: ");
 
int rows = Convert.ToInt32(Console.ReadLine());
 
 
for (int j = 0; j < rows; j++)
{
    int side = 1;
    for (int i = 0; i < rows - j; i++)
    {
        Console.Write("   ");
    }
 
    for (int k = 0; k <= j; k++)
    {
        Console.Write("   {0:D}  ", side); // форматирование целочисленных значений
        side = side * (j - k) / (k + 1);// расчет чисел для заполнения
    }
    Console.WriteLine();
    Console.WriteLine();
}
