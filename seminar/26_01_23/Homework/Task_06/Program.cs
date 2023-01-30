// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введи число a = ");
int a = int.Parse (Console.ReadLine());
int ost2 = 0;
if (ost2 == a % 2){
    Console.WriteLine("Да");
} 
else{
 Console.WriteLine("Нет");   
}