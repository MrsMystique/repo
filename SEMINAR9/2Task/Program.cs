/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SUMfromMtoN(int m, int n)
{
    if (m == n)
        return m;
    else
        return m + SUMfromMtoN(m + 1, n);
}


Console.Clear();

Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SUMfromMtoN(numberM, numberN));



