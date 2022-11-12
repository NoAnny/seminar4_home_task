//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int PowAB(int a, int b)
{
if (a == 0) return 0;
int pow = 1;    
for (int i = 0; i < b; i++)
{
    pow = pow * a;
}
return pow;
}

System.Console.WriteLine("Введите число А:");
int a = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число В:");
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Число {a} в степени {b} равно {PowAB(a, b)}");

