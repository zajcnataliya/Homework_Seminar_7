
void Zadacha53()
{
// Zadacha 53: Задайте двумерный массив. Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Поменяли местами первую и последнюю строку массива");

    int min_i = 0;
    int max_i = rows - 1;
    for (int j = 0; j < columns; j++ )
    {
        (numbers[min_i, j], numbers[max_i, j]) = (numbers[max_i, j], numbers[min_i, j]);
    }
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
            numbers[i, j] = random.Next(0, 15);
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

void Zadacha55()
{
// Zadacha 55: Задайте двумерный массив. Напишите программу, которая заменяет строки
// на столбцы. В случае, если это невозможно, программа должна вывести сообщение
// для пользователя.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = rows;
    Console.WriteLine($"Массив размера {rows}*{columns}");
    int[,] numbers = new int[rows, columns];

    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Заменили строки на столбцы");

       for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            // int temp = numbers[i, j];
            // numbers[i, j] = numbers[j, i];
            // numbers[j, i] = temp;
            (numbers[i, j], numbers[j, i]) = (numbers[j, i], numbers[i, j]); // кортеж
        }
    }
    PrintArray(numbers);
}

void Zadacha57()
{
// Zadacha 57: Составить частотный словарь элементов двумерного массива. Частотный словарь
// содержит информацию о том, сколько раз встречается элемент входных данных.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Массив размера {rows}*{columns}");
    FillArray(numbers);
    PrintArray(numbers);

    int[] counts = new int[10];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            counts[numbers[i, j]]++;
        }
    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Количество {i} в массиве равно {counts[i]}");
    }
}

void Zadacha59()
{
// Zadacha 59: Задайте двумерный массив из целых чисел. Напишите программу, которая
//удалит строку и столбец, на прересечении которых расположен наименьший элемент массива.

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] numbers = new int[rows, columns];
    Console.WriteLine($"Массив размера {rows}*{columns}");
    FillArray(numbers);
    PrintArray(numbers);

    int min = numbers[0, 0];
    int i_min = 0;
    int j_min = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (numbers[i, j] < min)
            {
                min = numbers[i, j];
                i_min = i;
                j_min = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"N[{i_min + 1}, {j_min + 1}] = {min}");

    int rowsResult = rows - 1;
    int columnsResult = columns - 1;
    int[,] result = new int[rowsResult, columnsResult];

    int bias_i = 0;
    int bias_j = 0;
    for (int i = 0; i < rowsResult; i++)
    {
        if (i == i_min) bias_i++;
        bias_j = 0;
        for (int j = 0; j < columnsResult; j++)
        {
            if (j == j_min) bias_j++;
            result[i, j] = numbers[i + bias_i, j + bias_j];
        }
    }
    Console.WriteLine();
    PrintArray(result);
    Console.WriteLine();
    for (int i = 0; i < rows; i++) // другой способ 
    {
        if (i != i_min)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j != j_min)
                    Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

void Zadacha58()
{
    // Задача 58: заполните спирально массив 4 на 4.
   
    Random random = new Random();
    int rows = 3;
    int columns = 5;
    int[,] numbers = new int[rows, columns];
    

    int index = 0;
    int currentRow = 0;
    int currentColumn = 0;

    int changeIndexRow = 0;
    int changeIndexColumn = 1;

    int steps = columns;
    int turn = 0;

    while(index < numbers.Length)
    {
        numbers[currentRow, currentColumn] = index + 1;
        //Console.Write(numbers[currentRow, currentColumn] + " ");
        index++;
        steps--;
        if (steps == 0)
        {
            // if (turn % 2 == 0)
            //         steps = rows - 1 - turn/2;
            // else        
            //         steps = columns - 1 - turn/2;
            steps = rows * ((turn+1)%2) + columns * (turn%2)- 1 - turn/2;
            int temp = changeIndexRow;
            changeIndexRow = changeIndexColumn;
            changeIndexColumn = -temp;
            turn++;
        }

        currentRow += changeIndexRow;
        currentColumn += changeIndexColumn;
    }
    PrintArray(numbers);
}

//Zadacha53();
//Zadacha55();
//Zadacha57();
//Zadacha59();
Zadacha58();

