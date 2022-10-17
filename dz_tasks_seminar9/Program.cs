void Zadacha64()
{
    // Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
    // M = 1; N = 5 -> 2, 4
    // M = 4; N = 8 -> 4, 6, 8
    
    Console.WriteLine("Задача 64");
    Console.WriteLine("Введите число M:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    FindNatural(n, m);

    void FindNatural(int n, int m)
    {
        m++;
        if ( m % 2 == 0)
        {
            Console.WriteLine(m);
        }
        if (m >= n)
        {    
            return;
        }
        FindNatural(n, m);
    }

}

void Zadacha66()
{
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
    Console.WriteLine("Задача 66");
    Console.WriteLine("Введите число M:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N:");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    FindSum(n, m, sum);

    void FindSum(int n, int m, int sum)
    {
        sum = sum + m;
        m++;
        if (m > n)
        {    
            Console.WriteLine("Сумма натуральных элементов от M до N = " + sum);
            return;
        }
        FindSum(n, m, sum);
    }


}

void Zadacha68()
{
// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7
    Console.WriteLine("Задача 68");
    Console.WriteLine("Введите число M:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N:");
    int n = Convert.ToInt32(Console.ReadLine());
    NOD(n, m % n);

    int NOD(int m, int n)
    {
        if (n == 0)
            return m;
    
        return NOD(n, m % n);
    }
    Console.WriteLine(n);



}


 



Zadacha64();
Zadacha66();
Zadacha68();
