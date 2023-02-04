/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int Fullnumber = Convert.ToInt32(Console.ReadLine());

while (Fullnumber < 10000 || Fullnumber > 99999)
{
    Console.WriteLine("Вы ошиблись, введите пятизначное число: ");
    Fullnumber = Convert.ToInt32(Console.ReadLine());
}

if (Fullnumber / 10000 == Fullnumber % 10 && (Fullnumber / 1000) % 10 == (Fullnumber / 10) % 10)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом");
};
