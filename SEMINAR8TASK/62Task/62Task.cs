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


int[,] PrintSpiral2DArray(int rows, int length)
{
    int[,] ArrayForSpiralFilling = new int[rows, length];

    int i = 0;
    int j = 0;

    int xAxisDirection = 1; 
    int yAxisDirection = 0;
    int direction = 0;
    int sideLength = length;

    for (int k = 0; k < ArrayForSpiralFilling.Length; k++)
    {
        ArrayForSpiralFilling[i, j] = k + 1;

        sideLength--;
        if (sideLength == 0)
        {
            sideLength = length * (direction % 2) + rows * ((direction + 1) % 2)- (direction/2 - 1) - 2;

            int temp = xAxisDirection;
            xAxisDirection = - yAxisDirection;
            yAxisDirection = temp;
            direction++;
        }
        i += yAxisDirection;
        j += xAxisDirection;
    }

    return ArrayForSpiralFilling;
}

Console.Clear();
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = PrintSpiral2DArray(row,column);
PrintMatrix(matrix);

