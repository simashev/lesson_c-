// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

using System;
using static System.Console; 

int [,,] array_3 = new int [2,2,2];

array_3 = GetArray(array_3, 10, 100);
PrintArray(array_3);

void PrintArray(int [,,] array){
        for (int i=0; i<array.GetLength(0);i++){
        for(int j=0; j<array.GetLength(1);j++){
            for(int k=0; k<array.GetLength(2);k++){
                Write($"{array [i,j,k]} ({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
}


int [,,] GetArray(int [,,] array, int min, int max){
    int [,,] a = new int [array.GetLength(0), array.GetLength(1),array.GetLength(2)];
    int [] temp = new int [array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
    // int [,,] a = array;
    for (int i=0; i<array.GetLength(0);i++){
        for(int j=0; j<array.GetLength(1);j++){
            for(int k=0; k<array.GetLength(2);k++){//3 51 45 18
                int b = new Random().Next(min,max);
                // for(b = new Random().Next(min,max);temp.Contains(b); b = new Random().Next(min,max)){
                // }
                while (temp.Contains(b)){
                    b = new Random().Next(min,max);
                }
                a [i,j,k] = b; //new Random().Next(min,max);
            }
        }
    }
    return a;
}

