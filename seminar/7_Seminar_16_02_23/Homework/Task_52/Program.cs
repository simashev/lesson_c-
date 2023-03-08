// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int [,] array = new int [rows,columns];

void GetArray (int [,] array){
for (int i = 0; i<array.GetLength(0);i++){
    for (int j = 0; j<array.GetLength(1);j++){
        array [i,j] = new Random().Next(1,10); 
    }
}
}
void PrintArray (int [,] array){
for (int i = 0; i<array.GetLength(0);i++){
    for (int j = 0; j<array.GetLength(1);j++){
        Write ($"{array[i,j]} "); 
    }
    WriteLine();
}
}

GetArray(array);
PrintArray(array);
Func();

void Func (){
    
double a = 0;
for (int i=0;i<array.GetLength(1);i++){
    for (int j=0; j<array.GetLength(0);j++){
        a = a + array [j,i];
    }
    double result = a/array.GetLength(0);
    WriteLine ($"Сумма числев в столбце {i}: {a}");
    a = 0;
    WriteLine ($"Среднее арифметическое столбца {i}: {result} ");
}
}
