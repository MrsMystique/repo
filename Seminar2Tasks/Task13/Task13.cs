/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.*/

Console.Clear ();
Console.Write ("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2;
while (num1/100<1 || num1/100>9 )
{
    Console.Write("Вы ошиблись!Введите трехзначное число: ");
    num1 = Convert.ToInt32(Console.ReadLine());
}
if (num1/100>=1)
{
    num2 = num1 % 100; 
    Console.WriteLine ($"В этом числе в разряде единиц цифра {num2%10}");  
}

