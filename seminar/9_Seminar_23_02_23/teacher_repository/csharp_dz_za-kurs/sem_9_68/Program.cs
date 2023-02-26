﻿//Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Clear();
Write("Введите M: ");
int a1 = int.Parse(ReadLine());
Write("Введите N: ");
int a2 = int.Parse(ReadLine());

WriteLine($"Функция Аккермана = {Akkerman(a1, a2)}");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}