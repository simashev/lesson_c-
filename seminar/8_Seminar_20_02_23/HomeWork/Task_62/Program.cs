// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// 01 02 03 
// 08 09 04
// 07 06 05 



// 01 02 03 04 05
// 16 17 18 19 06
// 15 24 25 20 07
// 14 23 22 21 08
// 13 12 11 10 09

//x3
//array[0,j] = 1-5
//array[j,length] = 5-9
//array[length,j] = 13-9

// x2
// k = i-1
//array[0,j] - j!=k and j!=length

// внешняя грань повторяется 3 раза, остальные - по 2

using System; 
using static System.Console; 

int [,] array = new int [6,6];
GetArray(array);
PrintArray(array);


void PrintArray (int [,] array){
    for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            if (array[i,j]<10)
                Write("0");
            Write($"{array[i,j]} ");    
        }
        WriteLine();
    }
} 

int [,] GetArray (int [,] array){

    int b = 0;
    for (int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(1); j++){
            b = j+1;
            array[0,j] = b;

            if(j!= i && j!=array.GetLength(0)-1-i && j!=array.GetLength(0)-1){
                array[j,0] = 4*array.GetLength(0) -3 -j;
            }
            if(i!=array.GetLength(0)-1 && j!=array.GetLength(0)-1-i && j!=array.GetLength(0)-1){
                array[i,j] = 1;
            }
            

        }//i = 3
        array[i,array.GetLength(0)-1] = b+i;//array[3,5] = 23
        array[array.GetLength(0)-1,i] = 3*array.GetLength(0)-2-i;
        
    }
    // for (int i=0; i<array.GetLength(0); i++){
    //             for (int j=0; j<array.GetLength(1); j++){

    //             }
    // }
    return array;
} 