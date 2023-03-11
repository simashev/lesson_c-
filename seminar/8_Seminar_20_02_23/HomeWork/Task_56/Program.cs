// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using System;
using static System.Console;

Write ("Введите число строк: ");
int rows = int.Parse(ReadLine());
Write ("Введите число колонок: ");
int columns = int.Parse(ReadLine());
int [,] arr = GetArray (rows, columns, 1, 10);
PrintArray(arr);
WriteLine("--");
//SortArray(arr);
Write(FindMaxRow(arr));


int [,] GetArray(int row, int column, int min, int max){
    int [,] array = new int [row,column]; 
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            array [i,j] = new Random().Next(min,max+1); 
        }
    }
    return array;
}

void PrintArray(int [,]array){
    for (int i=0; i<array.GetLength(0);i++){
        for (int j=0; j<array.GetLength(1);j++){
            Write($"{array[i,j]} "); 
        }
        WriteLine();
    }    
}

void PrintArray_1(int []array){
    for (int i=0; i<array.Length;i++){
        Write($"{array[i]} "); 
    }
        WriteLine();
    }    


int FindMaxRow (int [,] array){
    int maxrow = 0;
    int result = 0;
    int [] array_1 = new int [array.GetLength(0)]; 
    for (int i=0;i<array.GetLength(0);i++){
        for (int j=0;j<array.GetLength(1);j++){ 
            array_1 [i] = array_1 [i] + array[i,j]; 
        }
    }
    result=array_1[0];
    for (int k = 1; k<array_1.Length; k++){
        if (array_1 [k] < result){ // 1 2 3 
            result = array_1[k];//
            maxrow = k;//
        }
    }
    PrintArray_1(array_1);
    WriteLine();
    return maxrow+1;
    }


