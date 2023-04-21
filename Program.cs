// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNum(int n)
{
    Console.Write(n);
    if (n > 1)
    {
        PrintNum((n-1));
        
    }
}

PrintNum(3);

// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summ(int n, int m)
{
    
    if (n == m)
    {
        return n;
    }
    else
    {
        
        return n + Summ(n+1, m);
    }
}

Console.WriteLine(Summ(1, 5));

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29


Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
if (m == 0) 
{
    return n + 1;
}
else if (n == 0) 
{
    return akkerman(m - 1, 1);
}
else 
{
    return akkerman(m - 1, akkerman(m, n - 1));
}
}

Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");