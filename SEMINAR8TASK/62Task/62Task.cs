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


int[,] PrintSpiral2DArray(int height, int length)
{
    int[,] spiralArray = new int[height, length];

    int i = 0;
    int j = 0;

    int xDirection = 1, yDirection = 0;
    int direction = 0, sideLength = length;

    for (int k = 0; k < spiralArray.Length; k++)
    {
        spiralArray[i, j] = k + 1;

        --sideLength;
        if (sideLength == 0)
        {
            
            sideLength = length * (direction % 2) + height * ((direction + 1) % 2)- (direction/2 - 1) - 2;


            int temp = xDirection;
            xDirection = -yDirection;
            yDirection = temp;
            direction++;
        }
        i += yDirection;
        j += xDirection;
    }

    return spiralArray;
}
Console.Clear();
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = PrintSpiral2DArray(row,column);
PrintMatrix(matrix);
