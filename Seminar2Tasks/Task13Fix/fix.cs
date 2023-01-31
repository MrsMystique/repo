/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear ();
Console.Write ("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2;

while (num1/100<1)
{
    Console.Write("Третьей цифры нет.\n");
    num1 = Convert.ToInt32(Console.ReadLine());
}
if ((num1/100)<10)
{
    num2 = num1 % 100; 
    Console.WriteLine ($"третья цифра числа {num2%10}");  
}
while (num1/100>9)
{
    num1 = num1/10;
   
    if ((num1/100)<10)
    {
        num2 = num1 % 100; 
        Console.WriteLine ($"третья цифра числа {num2%10}");  
    }
}


