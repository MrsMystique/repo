Console.Clear();
Console.Write("Введите количество кустов от 3 до 1000: ");
int numberShrubs = Convert.ToInt32(Console.ReadLine());
int CurSum = 0;
int MaxSum = 0;
int i = 0;
while (numberShrubs < 3 || numberShrubs > 1000) 
{
    Console.Write("\nКоличество кустов должно быть от 3 до 1000\nвведите верное значение: ");
    numberShrubs = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine ("Количество кустов " + numberShrubs);
int[] CountBerrys = new int [numberShrubs];
// --------------------------------------------------------
void print_array(int[] array) 
{
    Console.Write("[");
    int index = 0;
    while (index < array.Length) 
    {
        Console.Write($"{array[index]}, ");
        index += 1;
    }
    Console.Write("\b\b]\n");
}
Console.Write("вот объявленный массив -->> ");
print_array(CountBerrys);
// --------------------------------------------------------
Console.WriteLine("Введите количество ягод на кустах");

for (int k = 0; k < numberShrubs; k++)
{   
    CountBerrys[k] = Convert.ToInt32(Console.ReadLine());
}

// надо заполнить массив
Console.WriteLine("Вывожу количество ягод на каждом кусте: \n");
Console.WriteLine("index" + " No.куста"  + " ягод");

for (int j = 0; j < numberShrubs; j++)
{
    Console.WriteLine (j + "\t"+ (j+1) + "\t" + CountBerrys[j]);
}
Console.WriteLine();

for (i = 0; i < numberShrubs-2; i++)
{
    CurSum = CountBerrys[i] + CountBerrys[i+1] + CountBerrys[i+2]; 
    Console.WriteLine("Iterat. " + "CurSum");
    Console.WriteLine (i + " \t " + CurSum);  
    if (CurSum > MaxSum) 
    {
      MaxSum = CurSum;  
    }  
}
if (i == numberShrubs - 2)
{
    CurSum = CountBerrys[0] + CountBerrys[numberShrubs-2] + CountBerrys[numberShrubs-1];  
    if (CurSum > MaxSum) 
    {
      MaxSum = CurSum;
    }  
}
i++;
if (i == numberShrubs - 1)
{
    CurSum = CountBerrys[0] + CountBerrys[1] + CountBerrys[numberShrubs-1];  
    if (CurSum > MaxSum) 
    {
        MaxSum = CurSum;  
    }  
}
Console.WriteLine($"Max = {MaxSum}");




