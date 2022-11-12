// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] RandomArray(int n)
{
    int [] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 10);
        System.Console.Write(array[i]);
    }
    return array;
}

System.Console.WriteLine("Введите длину массива");
int n = int.Parse(Console.ReadLine()!);
RandomArray(n);