// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
// int i = int.Parse (Console.ReadLine());
//int b = int.Parse (Console.ReadLine());
int a = int.Parse (Console.ReadLine());
int i = a / 10000;
int b = a % 10;
if (a < 10000 || a > 100000){
    Console.WriteLine("число введено не верно");
    }
else{ 
    if (i == b){
        Console.WriteLine("Является палиндромом");
    }
    else{
        Console.WriteLine("Не является палиндромом");
    }
}


    

