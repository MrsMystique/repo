﻿Console.Clear();
bool CheckPrime(int number)
{
    bool flag = true;//проверка положительна если число делится без остатка только на себя и на 1
    for (int j = 2; j < number - 1; j++)
   
        if (number % j == 0) // если делится на все числа без остатка то число не простое
       
            flag = false;
        
        return flag; // вернуть значение булевой переменной 
    
}
// Обьявляю переменные 
    int Num = 0;//четное число которое будем делить
    int Num1 = 0; //первое простое число
    int Num2 = 0; // второе простое число
    bool Flag = false;

    Console.WriteLine("Введите четное число");
    Num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < Num / 2 + 1; i++)
{
    if (CheckPrime(i) && CheckPrime(Num - i))
    {
        Flag = true;
        Num1 = i;
        Num2 = Num - i;
    }
}
if (Flag == true)
{
    Console.WriteLine("{0}+{1}={2}", Num1, Num2, Num);
}   
else
{
    Console.WriteLine("Не правда это все!");
    Console.ReadLine();
}