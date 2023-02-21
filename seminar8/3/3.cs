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
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.WriteLine("Введите количество строк в матрице: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице");
int column = Convert.ToInt32(Console.ReadLine());
// обьявим матрицу
int[,] matrix = new int[row, column];
int[] array = new int[coord[0] * coord[1]];
Console.WriteLine("Начальный массив: ");
int countArray = inputMatrix(matrix, array);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}]");
SwapFirstLastString(matrix, array, countArray);
InputMatrix(matrix);
PrintMatrix(matrix);

bool checkElement(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return false;
    }
    return true;
}

int inputMatrix(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            if (checkElement(array, matrix[i, j]))
            {
                array[k] = matrix[i, j];
                k++;
            }
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return k;
}


void SwapFirstLastString (int[,] matrix, int[] array, int countArray)
{
    for (int k = 0; k < countArray; k++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {       
                if (array[k] == matrix[i, j])
                    count++;
            }
        }
        Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
    }

}

