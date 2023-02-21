
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

int counter = 0;
int i = 0;
List <int> array = new List <int> (2);
foreach (int element in matrix)
   {
       array.Add(element);
       counter += 1;
       
   }
Console.WriteLine(counter);
int min = array[i];
Console.WriteLine($"Результат: [{string.Join(", ", array)}]");
for (i = 0; i < counter; i++)
{
    if(array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("Минимальный элемент массива = "+ min);

  for ( i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == min)
            {
                matrix[i, j] = 0;
            }
        }
        
    }

PrintMatrix(matrix);