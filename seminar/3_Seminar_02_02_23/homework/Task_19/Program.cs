// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: "); 
int a = int.Parse(Console.ReadLine());
int i = a / 10000;
int b = a % 10;
int c = (a / 1000) % 10;
int d = (a /10)  % 10;
if (a < 10000 || a > 100000){
    Console.WriteLine("число введено не верно");
    }
else{ 
    if (i == b && c == d){
        Console.WriteLine("Является палиндромом");
    }
    else{
        Console.WriteLine("Не является палиндромом");
    }
}


    
// Console.Clear();
// Console.Write("Введите число : ");
// int num = int.Parse(Console.ReadLine());//num = 12345
// int a1 = num / 10000; // num / 10000 = 1
// num = num - (a1 * 10000);  // 12345 - (1 * 10000) = 2345 <=> num = num % 10000 (2345)
// int a2 = num / 1000; // 2345 / 1000 = 2
// num -= a2 * 1000; // num = 345
// int a3 = num / 100; // 345 / 100 = 3
// num -= a3 * 100; // num = 45 
// int a4 = num / 10; // a4 = 45 / 10 = 4
// int a5 = num % 10; // a5 = 5 = 45 % 5
// if (a1 == a5 && a2 == a4)
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }


// Console.Clear();
// Console.Write("Введите число : ");
// int num = int.Parse(Console.ReadLine());int Revers(int num){
//     int revers = 0;// 54321
//     while (num > 0)
//         { // num = 0 > 0                        54320
//             revers = revers * 10 + num % 10; // revers = 5432 * 10 + num%10(1%10 = 1) = 54321
//             num /= 10; // num / 10(1/10)
//         }// 12345 == 54321
//     return revers;
// }
// if (num == Revers(num))
// {
//     Console.Write("Да");
// }
// else
// {
//     Console.Write("Нет");
// }