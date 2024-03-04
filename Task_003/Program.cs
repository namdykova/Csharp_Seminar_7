// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    System.Console.WriteLine("Введите размер массива: ");
    int size = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int[] array = CreateArray(size);
    PrintArray(array);
    PrintReversedArray(array, size);

}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
        array[i] = rand.Next(10, 100);
    return array;
}

void PrintArray(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        System.Console.Write(array[i] + " ");
        PrintArray(array, i + 1);
    }
}
void PrintReversedArray(int[] array, int size)
{
    if (size > 0)
    {
        System.Console.Write(array[size - 1] + " ");
        PrintReversedArray(array, size - 1);
    }
}

Main();

