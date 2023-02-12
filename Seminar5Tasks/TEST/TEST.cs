void print_array(char[] array) 
{
    Console.Write("[");
    int index = 0;
    while (index < array.Length) 
    {
        Console.Write($"{array[index]}0, ");
        index += 1;
    }
    Console.Write("\b\b]\n");
}

int FACTORIAL(int n)
{
    if (n==1)
    {
        return 1;
    }
    else 
    {
        return n* FACTORIAL(n-1);
    }
}
Console.Clear();
Console.WriteLine("Введите количество символов в строке: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"факториал {Number} = " + FACTORIAL(Number));
//----------------------------------------------------
char[]array = new char[Number];
Console.Write("вот объявленный массив -->> ");
print_array(array);
char temp;

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите символы: ");
    array[i] = Convert.ToChar(Console.ReadLine());
}

Console.WriteLine("Вывожу варианты для перестановки в данном массиве");
int count = 0;
if (Number == 2)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
    temp = array[0];
    array[0] = array[1];
    array[1] = temp;
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return;
}
if (Number == 1)
{
   Console.WriteLine($"Вариантов для перестановки одного символа не существет");
   return; 
}
for (int i = 0; i < FACTORIAL(Number)/2; i++)
{
       
    for (int j = 0; j < Number-1; j++)
    {
        temp = array[j];
        array[j] = array[array.Length-1];
        array[array.Length-1] = temp;
        count++;
        Console.WriteLine($"Текущее состояние массива: [{string.Join(", ", array)}]");
    }
           
}
 Console.WriteLine($"ИТЕРАЦИЙ = {count}");   
    