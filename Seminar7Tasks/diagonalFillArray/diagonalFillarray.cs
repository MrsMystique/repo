
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
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
int size = row * column;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j <= i; j++)
    {
         
            matrix[i, j] = j;
             
       
    }     
}
PrintMatrix(matrix);