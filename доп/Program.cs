// Выдов простых чисел от 1 до N
//System.Console.WriteLine("Введите число N:");
//int n = int.Parse(Console.ReadLine()!);
//Console.WriteLine ($"Ряд простых чисел от 1 до {n}:");
//for (int current = 2; current <= n; current++)
//{
    //bool isPrime = true;
    //for (int i = 2; i < current; i++)
   // {
    //    if (current % i == 0) isPrime = false;
    //    break;
    //}
    //if (isPrime) Console.Write(current + " "); 
//}

System.Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine ($"Ряд простых чисел от 1 до {n}:");

for (int current = 2; current <= n; current++)
{
    if (isPrime(current)) Console.Write(current + " "); 
}
 
 bool isPrime (int number)
 { 
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0) return false;
    }
return true;
 }