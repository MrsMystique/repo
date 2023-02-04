
/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();

    Console.Write("Введите координату X(1): ");
    double x1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координату Y(1): ");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координату Z(1): ");
    double z1 = Convert.ToDouble(Console.ReadLine());


    Console.Write("Введите координату X(2): ");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координату Y(2): ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите координату Z(2): ");
    double z2 = Convert.ToDouble(Console.ReadLine());

double Distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine(Math.Round(Distance, 2));
