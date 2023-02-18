/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
        }
           
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
InputMatrix(matrix);
PrintMatrix(matrix);
int avgCol, sumCol = 0;

//быстрые итерации должны быть по вертикали, медленные по горизонтали. вложенные циклы. 
//пробегаюсь по всем строкам столбца
//суммирую все элементы. когда достигаю последней строки - вычисляю среднее арифмет
//повторяю пока не попытаюсь выйти за границы столбцов матрицы
// ПРоверки: распечатываю итераторы, и результаты расчетов на каждом этапе
for (int i = 0; i < column; i++)
{     
    for (int j = 0; j < row; j++)
    {
        sumCol += matrix[j,i]; // здесь была проверка каждой суммы двух элементов Console.Writeline($"Текущая сумма элементов столбцы = {sumCol += matrix[j,i]}")
        if (j == column - 1)
        {
            avgCol = sumCol/(column);
            Console.WriteLine($"Среднее арифметическое столбца {i} = {avgCol}");
            sumCol = 0;
        }
    }
        
}