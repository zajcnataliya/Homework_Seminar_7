
void Zadacha54()
{
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
    Console.WriteLine("Задача 54");
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine($"\nУпорядоченный массив: ");
    SortArray(numbers);
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
            numbers[i, j] = random.Next(0, 10);
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

void SortArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int border = columns - j - 1;
                for (int k = 0; k < border; k++)
                {
                    if (numbers[i, k] < numbers[i, k + 1]) 
                    {
                        (numbers[i, k], numbers[i, k + 1]) = (numbers[i, k + 1], numbers[i, k]);
                        // int temp = numbers[i, k + 1];
                        // numbers[i, k + 1] = numbers[i, k];
                        // numbers[i, k] = temp;
                    }
                }
            }
        }
}

void Zadacha56()
{
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

    Console.WriteLine("Задача 56");
    Random random = new Random();
    int rows = random.Next(2, 4);
    int columns = random.Next(2, 4);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();

    int sumMin = SumInRow(numbers, 0);
    int indexMin = 0;                   //за минимальную сумму считаем сумму элементов первой строки
    // for (int j = 0; j < columns; j++)
    // {
    //     sumMin += numbers[0, j];
    // }
    // Console.WriteLine($"Сумма {indexMin + 1} строки равна {sumMin}");

    for ( int i = 1; i < rows; i++)    // начинаем с i = 1, т.к. сумму первой строки мы нашли
    {
        int sum = SumInRow(numbers, i);
        if (sum < sumMin)
        {
            sumMin = sum;
            indexMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма равна {sumMin} и находится в строке {indexMin + 1}");

    
int SumInRow(int[,] numbers, int i)
{
    int columns = numbers.GetLength(1);
    int sum = 0;
    for (int j = 0; j < columns; j++)
    {
        sum += numbers[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} строки равна {sum}");
    return sum;
} 
    

}
void Zadacha58()
{
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

    Console.WriteLine("Задача 58");
    Random random = new Random();
    int rowsFirst = random.Next(4, 8);
    int columnsFirst = random.Next(4, 8);
    int rowsSecond = columnsFirst;
    int columnsSecond = random.Next(4, 8);
    
    int[,] firstMatrix = new int[rowsFirst, columnsFirst];
    int[,] secondMatrix = new int[rowsSecond, columnsSecond];
    
    FillArray(firstMatrix);
    PrintArray(firstMatrix);
    Console.WriteLine();
    FillArray(secondMatrix);
    PrintArray(secondMatrix);

    int[,] result = new int[rowsFirst, columnsSecond];

    for (int i = 0; i < rowsFirst; i++)
    {
        for (int j = 0; j < columnsSecond; j++)
        {
            for (int k = 0; k < rowsSecond; k++)
            {
                result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    Console.WriteLine();
    PrintArray(result);
}

Zadacha54();
Zadacha56();
Zadacha58();