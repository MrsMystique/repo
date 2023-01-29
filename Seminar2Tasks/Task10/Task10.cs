/*Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear ();
Console.Write ("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2;
while (num1/100<1)
{
    Console.Write("Вы ошиблись!Введите трехзначное число: ");
    num1 = Convert.ToInt32(Console.ReadLine());
}
if (num1/100>=1)
{
    num2 = num1 % 100; 
    Console.WriteLine ($"В этом числе в разряде десятков цифра {num2 / 10}");  
}

