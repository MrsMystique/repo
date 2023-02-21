void RowsMATRIXTRANSPONSED(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)/2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j]; // во временную ячейку кладу матрикс 0.0
            matrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];// в матрикс 0. -i -1 (n -0-1) - последняя ячейка
            matrix[matrix.GetLength(0)- i - 1, j] = temp;
        }
    }
    
}
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
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

int [,] matrix = new int[row, column];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
// распечатаем индексы этой матрицы для хоть какого то понимания сути
// распечатаем индексы этой матрицы для хоть какого то понимания сути

Console.WriteLine("Конечный массив:");
RowsMATRIXTRANSPONSED(matrix);
PrintMatrix(matrix);