﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введи число a = ");
int a = int.Parse (Console.ReadLine());
Console.Write ("введите число b = ");
int b = int.Parse (Console.ReadLine());
Console.Write ("введите число c = ");
int c = int.Parse (Console.ReadLine());

if (a < b){
    if (b < c){
        Console.WriteLine($"max = {c}");
    } 
    else{
        Console.WriteLine($"max = {b}");   
    }
} 
else{
 Console.WriteLine($"max = {a}");   
}

//int max = a;
//int max = b; 