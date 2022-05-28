//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine ("Введите число ");
int range = Convert.ToInt32(Console.ReadLine( ));
int a = range;
if (a % 2 == 0) Console.WriteLine("Чётное");
else Console.WriteLine("Нечётное");
                