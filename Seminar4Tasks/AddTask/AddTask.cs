/*Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность 
(сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
Входные данные
Первая строка  содержит натуральное число N, 
во второй строке записаны N целых чисел Ai, 
в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

Выходные данные
В выведите полученную последовательность.*/

Console.Clear();
Console.Write("Введите количество чисел в последовательности: ");
int number = Convert.ToInt32(Console.ReadLine());
while (1 > number || number > 105) // проверка количества элементов
    {
        Console.Write("Введите значение больше  1 меньше 105: ");
        number = Convert.ToInt32(Console.ReadLine());
    }

Console.Write("Введите сдвиг: ");
int Shift = Convert.ToInt32(Console.ReadLine());

while (Shift == 0) // проверка на 0
{
    Console.Write("Введите число отличное от нуля: ");
    Shift = Convert.ToInt32(Console.ReadLine());
}

// создаем массив и заполняем
int[] Arr = new int [number];
// --------------------------------------------------------
void print_array(int[] array) 
{
    Console.Write("[");
    int index = 0;
    while (index < array.Length) 
    {
        Console.Write($"{array[index]}, ");
        index += 1;
    }
    Console.Write("\b\b]\n");
}
Console.Write("вот объявленный массив -->> ");
print_array(Arr);
// --------------------------------------------------------

for (int k = 0; k < number; k++)
{   
    Console.WriteLine("Введите элементы массива");
    Arr[k] = Convert.ToInt32(Console.ReadLine());

    while (Arr[k] > 100) // проверка элементов
    {
        Console.Write("Введите значение меньше либо равно 100: ");
        Arr[k] = Convert.ToInt32(Console.ReadLine());
    }
}

// вывожу заполненный
Console.WriteLine("Вывожу заполненный массив: \n");
Console.WriteLine("index" + " Элемент");

for (int j = 0; j < number; j++)
{
    Console.WriteLine (j + "\t" + Arr[j]);
}
Console.WriteLine();

if (Shift > 0)
{
    int [] temp = new int [Shift]; 
    Array.Copy(Arr, Arr.Length - Shift, temp, 0, Shift); 
    Array.Copy(Arr, 0, Arr, Shift, Arr.Length - Shift); 
    Array.Copy(temp, 0, Arr, 0, temp.Length);
}
else
{
    Shift = -Shift;
    int [] temp = new int[Shift]; 
    Array.Copy(Arr, temp, Shift); 
    Array.Copy(Arr, Shift, Arr, 0, Arr.Length - Shift); 
    Array.Copy(temp, 0, Arr, Arr.Length - Shift, temp.Length); 
}

Console.WriteLine($"Результат: [{string.Join(", ", Arr)}]");
