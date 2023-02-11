/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
// 1. пишем функцию для заполнения кторая по типу здесь нужна
Console.Clear();
 
 void INPUTARRAY(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100); // [типа случайные]
    }
        
}
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
INPUTARRAY(array); // заполняю функцией рандомного заполнения
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int sum = 0;
// суммируем все с четным индексом (шаг 2)
for (int i = 1; i < array.Length; i+=2)
{
    sum = sum + array[i];
    Console.WriteLine($"Прибавила элемент с индексом {i}, равный {array[i]}");
}
Console.WriteLine("Итого:" + sum);

// выводим на экран