   
            Console.Write("Введите количество строк треугольника Паскаля: ");
            int input = Convert.ToInt32(Console.ReadLine());
 
            int rows = Convert.ToInt32(input);
 
 
            for (int j = 0; j < rows; j++)
            {
                int side = 1;
                for (int i = 0; i < rows - j; i++)
                {
                    Console.Write("   ");
                }
 
                for (int k = 0; k <= j; k++)
                {
                    Console.Write("   {0:D}  ", side);
                    side = side * (j - k) / (k + 1);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
           