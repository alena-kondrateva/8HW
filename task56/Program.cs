// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов.

void Main()
{
    Console.WriteLine("Введите количество строк");
    int rows = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = new int[rows, columns];

    if (rows == columns)
    {
        GetArray(array);
        PrintArray(array);
        Console.WriteLine();
        SumNumbers(array);
    }
    else
    {
        Console.Write("Ошибка! Количество столбцов должно быть равно количесству строк.");
    }


}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void SumNumbers(int[,] numbers)
{
    int minsum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов -> {indexLine}");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Main();
