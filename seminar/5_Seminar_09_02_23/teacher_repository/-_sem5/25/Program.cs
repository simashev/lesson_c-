﻿Console.Clear();
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} = {Pow(A,B)}");


int Pow(int num, int rank)
{
    if(B==0) return 1;

    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}