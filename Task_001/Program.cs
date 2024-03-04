// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от M до N. Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("введите число N: ");
    PrintNumbers(M, N);
}

void PrintNumbers(int M, int N)
{
    if (N < M) return;
    PrintNumbers(M, N - 1);
    System.Console.Write(N + " ");
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
Main();