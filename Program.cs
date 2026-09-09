
using System;

Console.WriteLine("Hello, World!");


// Версия 2.0
partial class Program
{
    // Главная точка входа в программу
    static void Main(string[] args)
    {
        
    }

    // Метод сложения (сделан static, чтобы его можно было вызвать из Main)
    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

