// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
int n = 1 ;
for (int i = n; i <= m; i++)
 {
   if (i % 2 == 0) 
  {
   Console.Write(i + " ");
  }
 }
 Console.WriteLine ( );