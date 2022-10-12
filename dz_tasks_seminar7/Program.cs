
void Zadacha47()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
    // вещественными числами.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9

    Console.WriteLine("Задача 47");
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

void Zadacha50()
{
// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

    Console.WriteLine("Задача 50");
    Random random = new Random();
    int rows = random.Next(2, 4);
    int columns = random.Next(2, 4);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    Console.WriteLine("Введите позиции элемента в двумерном массиве: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int index = 0;
    if (a > 0 && b > 0 && a <= rows && b <=columns)
    {
        for (int i = 0; i < a; i++)
        {
            for (int j =0; j < b; j++)
            {
                index = numbers[a - 1, b - 1];
            }
        }
        Console.WriteLine("Значение элемента равно: " + index);
    }
    else
    {
        Console.WriteLine($"{a} и {b}: таких элементов нет в массиве");
    }
}


void Zadacha52()
{
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    Console.WriteLine("Задача 52");
    Random random = new Random();
    int rows = random.Next(2, 5);
    int columns = random.Next(2, 5);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);

    double averSum = 0;
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {             
            sum = sum + numbers[i,j];                   
        }
        averSum = Math.Round(sum / rows, 1);
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца = {averSum}");
    }
}


Zadacha47();
Zadacha50();
Zadacha52();