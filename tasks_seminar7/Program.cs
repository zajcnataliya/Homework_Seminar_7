
void Zadacha46()
{
    // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
    // m = 3, n = 4.
    // 1 4 8 19
    // 5 -2 33 -2
    // 77 3 8 1

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(-10, 10);
        }
    }
}
void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void Zadacha48()
{
    // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве
    // находится по формуле: Aₘₙ = i+j. Выведите полученный массив на экран.
    // m = 3, n = 4.
    // 0 1 2 3
    // 1 2 3 4
    // 2 3 4 5

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

    FillArrayIndexSum(numbers);
    PrintArray(numbers);

    void FillArrayIndexSum(int[,] numbers)
    {
        Random random = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i, j] = i + j;
            }
        }
    }
    
}

void Zadacha49()
{
    // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса
    // чётные, и замените эти элементы на их квадраты.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    for (int i = 0; i < rows; i += 2)
    {
        for (int j = 0; j < columns; j += 2)
        {
            numbers[i, j] = numbers[i, j] * numbers[i, j];
        }
    }
    Console.WriteLine();
    PrintArray(numbers);
}

void Zadacha51()
{
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1;1) и т.д.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = rows;
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];
    int sum = 0;
    FillArray(numbers);
    PrintArray(numbers);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                sum = sum + numbers[i, j];
            }
        }
    }
    Console.WriteLine(sum);


}
// Zadacha46();
// Zadacha48();
// Zadacha49();
Zadacha51();