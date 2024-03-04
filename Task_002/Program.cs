// Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

void Main()
{
    int m = ReadInt("Введите M: ");
    int n = ReadInt("Введите N: ");
    System.Console.WriteLine(Ack(m, n));
}

int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if((m > 0) && (n == 0))
    {
        return Ack(m - 1, 1);
    }
    else if((m > 0) && (n > 0))
    {
        return Ack(m - 1, Ack(m, n - 1));
    }
    else 
    {
        return 0;
    }
}

int ReadInt(string msg)
{
    System.Console.WriteLine(msg);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

Main();