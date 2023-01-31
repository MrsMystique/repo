// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=3&id_topic=35&id_problem=223


int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
int max2 = 0;


while(n != 0)
{  
   if (max < n)
   { 
      max2 = max;
      max = n;
   }
  
   n = Convert.ToInt32(Console.ReadLine()); 

   if (n > max2 && n < max)
   {
      max2 = n;    
   }
}

Console.Write(max2);


       