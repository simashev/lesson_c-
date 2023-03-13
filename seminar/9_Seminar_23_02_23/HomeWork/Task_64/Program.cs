// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using System;
using static System.Console;

Write ("Введите число N: ");
int N = int.Parse(ReadLine());

FindNatural(N);


string FindNatural (int x){
    if (x == 1){
        Write(x);
        return $"{x}";
    }
    Write ($"{x} ");
    return (x.ToString()+ ' ' + FindNatural(x-1));


}

