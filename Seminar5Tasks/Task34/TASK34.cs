/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

//void заполнение массива случайными положительными числами uint
//чек на четность функция
Console.Clear();
 
 void INPUTARRAY(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000); // [положительные трехзначные]
    }
        
}

int EVENCHECK(int[] array)
{
    int count = 0;

    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            count++;
        }
           
    }
    return count;            
}

// Заполняю и вывожу массив с исползованием функции рандомного заполнения
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
INPUTARRAY(array); // заполняю функцией рандомного заполнения
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

// проверяю на четность
int countEven = EVENCHECK(array);
Console.WriteLine($"В массиве {countEven} четных чисел");


