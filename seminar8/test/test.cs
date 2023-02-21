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
// окей. примем размер матрицы
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице");
int column = Convert.ToInt32(Console.ReadLine());
// обьявим матрицу
int[,] matrix = new int[row, column];
// пока не ясно для чего создадим вложенные циклы для перебора
// распечатаем индексы этой матрицы для хоть какого то понимания сути
for (int i = 0; i < row; i++)
{   
    Console.WriteLine("\n");
    for (int j = 0; j < column; j++)
    {
        Console.Write($"[{i},{j}]  \t");
    }
}
int k = 0;
int rowIterator = 2;
for (int i = 0; i < row; i++)
{   
    Console.WriteLine("\n");
    for (k = 0; k < column; k++)
    {
            matrix[i, k] = k + 2;
            Console.Write($"[{matrix[i, k]}]  \t");
               
    }
    
}
