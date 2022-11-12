// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
int SumDigit(int n)
{
    int lenght = Convert.ToString(n).Length;
    int sum = 0;
    if (n < 10 && n >= 0) return n;
    for (int i = 0; i < lenght; i++)
    {
        sum = sum + (n % 10);
        n = n / 10;
    }
    return Math.Abs(sum);
    }

System.Console.WriteLine("Введите любое целое число :");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Сумма цифр числа {n} равна {SumDigit(n)}");