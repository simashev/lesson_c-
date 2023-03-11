// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;

Write ("Введите число строк: ");
int rows = int.Parse(ReadLine());
Write ("Введите число колонок: ");
int column = int.Parse(ReadLine());
int [,] arr = new int [rows,column];
GetArray(arr);
PrintArray(arr);
WriteLine("--");
SortArray(arr);
PrintArray(arr);

void GetArray(int [,] array){
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array[i,j] = new Random().Next(1,10); 
        }
    }
}

void PrintArray(int [,]array){
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            Write($"{array[i,j]} "); 
        }
        WriteLine();
    }    
}

int [,] SortArray (int [,] array){
    for (int i=0;i<array.GetLength(0);i++){
        for (int j=0;j<array.GetLength(1);j++){
            for(int m =j;m<array.GetLength(1); m++){// 4 2 3 7 4 8
                if (array[i,j] < array[i,m]){//0 - 1 - 2 - 3 - 4
                int k = array [i,j]; // 4
                array [i,j] = array [i,m];// 00 = 7
                array [i,m] = k; //03 = 4
            } // 7 2 3 4 4 8 
            }
        }
    }
    return array;

}
