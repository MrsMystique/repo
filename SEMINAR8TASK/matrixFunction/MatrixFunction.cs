int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    if (cols1 != rows2)
    {
        throw new ArgumentException("Matrices cannot be multiplied");
    }

    int[,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}
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
// Создаем первую матрицу размера row*column . Для первой матрицы вожно количество строк
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[row, column];

// Создаем вторую матрицу.  она должна иметь столбцов столько сколько строк в первой матрице и строк столько, сколько столбцов в первой матрице.
// можно было бы натворить кучу проверок. но я заменю данные  строк и столбцов местами и вуаля. получу нужную матрицу
int[,] matrixB = new int[column, row];
// Заполняю матрицу А. вывожу
InputMatrix (matrixA);
Console.WriteLine("Исходный массив А: ");
PrintMatrix(matrixA);
InputMatrix (matrixB);
Console.WriteLine("Исходный массив B: ");
PrintMatrix(matrixB);
// создаю результирующую матрицу. она равна будет Количество строк в A  и столбцов как в В
int[,] matrixResult = new int[row,row];
Console.WriteLine("Выходная Матрица: ");
PrintMatrix(MultiplyMatrices(matrixA, matrixB));