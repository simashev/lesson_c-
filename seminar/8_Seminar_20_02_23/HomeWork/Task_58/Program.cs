// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Write("Введите количество строк матрицы 1 = ");
int rows = int.Parse(ReadLine());
Write ("Введите количество столбцов матрицы 1 = ");
int columns = int.Parse(ReadLine());
Write("Введите количество строк матрицы 2 = ");
int rows_2 = int.Parse(ReadLine());
Write ("Введите количество столбцов матрицы 2 = ");
int columns_2 = int.Parse(ReadLine());

int [,] array_1 = GetArray (rows, columns, 1, 10); 
int [,] array_2 = GetArray (rows_2, columns_2, 1, 10);
PrintArray(array_1);
WriteLine();
PrintArray(array_2);
int [,] result = FindComposition(array_1, array_2);
WriteLine("--");
PrintArray(result);

int [,] GetArray (int rows, int columns, int min, int max){
    int [,] array = new int [rows, columns];
    for (int i=0; i < rows; i++){
        for (int j=0; j<columns; j++){
            array [i, j]= new Random().Next(min, max+1);
        }
    }
    return array; 
}

void PrintArray (int [,] array){
    for(int i=0; i<array.GetLength(0);i++){
        for(int j=0; j<array.GetLength(1); j++){
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}

int [,] FindComposition (int [,] array_1, int [,] array_2){
    int sum = 0;
    int [,] array = new int [array_1.GetLength(0),array_2.GetLength(1)];
    if (array_1.GetLength(1) == array_2.GetLength(0)){
        for (int i=0; i<array_1.GetLength(0);i++){
            for (int j=0; j<array_2.GetLength(1);j++){
                for (int k=0; k<array_2.GetLength(0);k++){
                    array[i,j] += array_1[i,k]*array_2[k,j];
                }
             }
            }
        }

    else {
        WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В.");
    }
    return array;
}
