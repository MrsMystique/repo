﻿Console.Clear();
// булевая функчия чек на простое число
bool CheckPrime(int number)
{
    bool flag = true;// объявлена булевая переменная. содержит значение истина априори
    
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

for (int i = 1; i < Num / 2 + 1; i++) // итерации до половины введенного числа +1
{
    if (CheckPrime(i) && CheckPrime(Num - i)) // проверяем итератор (является ли он простым числом) и остаток от числа функцией
    {
        Flag = true; // если функция возвращает правду, то присваиваем переменным значения этих простых чисел
        Num1 = i;
        Num2 = Num - i;
    }
}
if (Flag == true)
{
    Console.WriteLine($"{Num1} + {Num2} = {Num}"); // вывести в виде суммы простых чисел
}   
else // иначе написать что то гневное
{
    Console.WriteLine("Не правда это все!");
    Console.ReadLine();
}