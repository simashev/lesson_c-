// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29using System;

using System;
using static System.Console;

Write ("Введите число M: ");
int M = int.Parse(ReadLine());

Write ("Введите число N: ");
int N = int.Parse(ReadLine());

WriteLine (A(M,N));

int A(int M, int N){
    int result = 0; 
    if (M>0 && N>0){
        result = A(M-1,A(M,N-1));
        M = M-1;
        N = N-1;
    return result;
    }
    if (M>0 && N==0){
        result = A(M-1,1);
        M = M-1;
        N = 1;
    return result;
    }
    if (M==0){
        result = N+1;
        M = 0;
    return result;
    }
    return result;
}


