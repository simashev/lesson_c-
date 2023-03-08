// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

using System;
using static System.Console;
Clear();
int m = 3;
int n = 4;

double [,] a = GetArray(m,n);

PrintArray (a);
void PrintArray(double [,] parray){ //parray = a

for (int j =0; j<m;j++){
    for (int i =0; i<n;i++){
    Write($"{parray[j,i]} "); 
}
WriteLine (); 
}
}

double[,] GetArray(int rows, int columns){
double [,] array = new double [rows, columns];
for (int j =0; j<rows;j++){
    for (int i =0; i<columns;i++){
        
        array [j,i] = Math.Round(new Random().NextDouble() * new Random().Next(-100,100),2);// 0 .... 1 * -1 ....1
}
}
return array;
}
