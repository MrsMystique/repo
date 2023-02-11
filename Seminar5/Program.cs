void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-9, 10); // [-9, 9]
}

void ReleaseArray(int[] array)
{
  int summaPositive = 0, summaNegative = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < 0)
    {
        array[i] = array[i] * (-1);
    }
    else
    {
        array[i] = array[i] * (-1);
    }
  }
  Console.WriteLine($" Массив {array}");
 
}


Console.Clear();
int[] array = new int[12];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");