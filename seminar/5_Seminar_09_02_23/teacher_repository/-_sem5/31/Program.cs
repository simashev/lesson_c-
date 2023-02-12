﻿//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

// GetArray(12,-9,9)


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
















int[] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)//[1, 2, 3, 4, -5, 1, -3] el = -5
{
    positiveSum += el > 0 ? el : 0;//ps += -5 > 0? 2 : 0;
    negativeSum += el < 0 ? el : 0;
}
//  for (int i = 0;i < array.Length; i++){
//     int el = array[i];
    // if(el > 0)
    //     positiveSum += el;
    // if(el < 0)
    //     negativeSum += el;
// } 
Console.WriteLine($"Positive sum = {positiveSum}, negative sum = {negativeSum} ");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}


/* **Задача 32:**Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]*/