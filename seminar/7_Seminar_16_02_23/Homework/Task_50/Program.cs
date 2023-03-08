// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

using System;
using static System.Console;

int [,] array = new int [5,5];
Write("Введите номер строки: ");
int row = int.Parse(ReadLine());
Write ("Введите номер колонки: ");
int column = int.Parse(ReadLine());
GetArray(array);



// row= 
// column =
// длина массива
if (row < array.GetLength(0) && column < array.GetLength(1) && row >= 0 && column >= 0){
    WriteLine(array[row,column]);
}
else
{
   WriteLine("Такого элемента нет!"); 
}
WriteLine();
PrintArray(array);

void PrintArray (int [,] array){
for (int i=0; i<array.GetLength(0);i++){
    for (int j=0; j<array.GetLength(1);j++){
        Write ($"{array [i,j]} ");
    }
    WriteLine();
}
}




void GetArray (int [,] array){
for (int i=0; i<array.GetLength(0);i++){
    for (int j=0; j<array.GetLength(1);j++){
        array [i,j] = new Random().Next(1,10);
    }
}
}

