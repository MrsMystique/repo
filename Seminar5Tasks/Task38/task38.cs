/* Задача 38: Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.1, 7.23, 22.57, 2.45, 78.78] -> 76.33 */

// 1. пишем функцию для заполнения в даблах. округлим до 2 знаков после запятой
Console.Clear();
 
 void INPUTARRAY(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble(); // [типа случайные дробные] 
        array[i] = Math.Round((array[i]*10), 2); // округлим до 2 знаков после запятой и домножим на 10, дабы все они были более большими
    }
        
}
Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double [n];
INPUTARRAY(array); // заполняю функцией рандомного заполнения
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// MAx
double max = array.Max();
Console.WriteLine("Максимальный элемент массива = " + max);
// min
double min = array.Min();
Console.WriteLine("Минимальный элемент массива = " + min);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива, то есть {max} - {min} = {Math.Round(max-min), 2}");