/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
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
Console.WriteLine("Введите количество столбцов в матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
InputMatrix (matrix);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
int RowElementSum = 0; // по ходу дела переборщила я с переменными. ща исправлю
int minValueRow = 0;
int i = 0;
int tempNumberRow = 0; // так как существовала проблема с сохренением номера строки с минимальной суммой элементов. будем хранить это в переменной
// суммируем элементы массива 1 стр и кладем в сумма. строку суммирует. все норма
// сравниваем кладем в мин
// суммируем строку 2 в перемнную сумма..сравниваем с 1. если 1 меньше. то мин 1. если больше - мин строка 2

// Находим первое значение чтоб считать его минимальным на текущий момент
while ( i == 0)
{   
    for (int j = 0; j < column; j++)
    {
        RowElementSum = RowElementSum + matrix[i ,j];
    }
    Console.WriteLine($" сумма строки {i}  = {RowElementSum} ");
    tempNumberRow = i;
    i++;
    minValueRow = RowElementSum;
}
Console.WriteLine($" Минимальное значение на начало расчетов будет суммой элементов 0 строки {minValueRow} ");
// начинаем работать начиная со второй строки и сравниваем с мин элементом
Console.WriteLine($" Суммирую остальные сроки, сравнивая с текущей минимальной");
for (int k = 1; k < row; k++)
{       RowElementSum = 0; // обнулю
        for (int j = 0; j < column; j++)
        {
            RowElementSum = RowElementSum + matrix[k ,j];
        }

        Console.WriteLine($"  {k}  = {RowElementSum} ");

        if (RowElementSum < minValueRow)
        {
            minValueRow = RowElementSum;
            tempNumberRow = k;
        }
        
}
Console.WriteLine($" сумма элементов строки {tempNumberRow}  = {minValueRow} итоговое минимальное значение");