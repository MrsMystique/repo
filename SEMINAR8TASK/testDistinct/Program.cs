Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
double []sum = new double [size[1]];



for (int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
      matrix[i, j] = Math.Round((new Random().NextDouble()*100),0); 

        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<matrix.GetLength(1); i++)
{
    for(int j=0; j<matrix.GetLength(0); j++)
    {
        sum[i] += matrix[j, i];
    }
}

for (int i=0; i<matrix.GetLength(1); i++)
{
    double result = 0;
    result = sum[i] / matrix.GetLength(0);
    Console.WriteLine($"Среднее арифметическое равно: {result}");
}
Console.ReadLine();