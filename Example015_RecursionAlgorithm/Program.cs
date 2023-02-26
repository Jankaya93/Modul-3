﻿// ===== факториал

// double Factorial(int n)
// {
//     if (n == 1 || n == 0) return 1;
//     else return n * Factorial(n-1);
// }

// for (int i = 1; i < 40; i++)
// {
//     System.Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// ===== числа Фибоначчи
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 40; i++)
{
    System.Console.Write(Fibonacci(i) + " ");
}