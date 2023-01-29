Console.Clear();
Console.WriteLine("Введите число1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int m = Convert.ToInt32(Console.ReadLine());
int result = 0;
if(n==m*m)
{
Console.WriteLine("Первое число является квадратом второго");
}
else if(m==n*n)
{
Console.WriteLine("Второе число является квадратом первого");
}
else
{
Console.WriteLine("Ни одно число не является квадратом второго");
}


