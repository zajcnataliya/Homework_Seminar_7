
void Zadacha63()
{
//Задача 63: Задайте значения N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N (рекурсией).

Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 0;
Console.WriteLine();
FindNatural(number, counter);

void FindNatural(int number, int counter)
{
    counter++;
    Console.WriteLine(counter);
    if (counter >= number)
    {
        return;
    }
    FindNatural(number, counter);
}
}


void Zadacha65()
{
//Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N (рекурсией).

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
//int counter = 0;
Console.WriteLine();
FindNatural(n, m);

void FindNatural(int m, int counter = 1)
{
    Console.WriteLine(counter);
    counter++;
    if (counter >= m)
    {
        return;
    }
    FindNatural(m, counter);
}
}

void Zadacha67()
{
//Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать его сумму чисел (рекурсией).

}
//Zadacha63();
//Zadacha65();
Zadacha67();