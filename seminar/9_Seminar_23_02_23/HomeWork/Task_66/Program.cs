// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Write ("Введите число M: ");
int M = int.Parse(ReadLine());

Write ("Введите число N: ");
int N = int.Parse(ReadLine());

WriteLine (FindSum(M,N));
int FindSum(int M, int N){
    if (M == N) 
        return M;
    return (M + FindSum(M+1, N));
}


