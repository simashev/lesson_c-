// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введи число N = ");
int N = int.Parse (Console.ReadLine());
for (int i=1; i <= N; i++){
if ((i % 2) == 0){
    Console.Write($"{i}, ");
} 
}




// Console.Clear();
// Console.Write("Введи число N = ");
// int N = int.Parse (Console.ReadLine());
// int ost2 = N/2;
// int a = 0;
// for(int i=1;i<=ost2;i++){
//     Console.Write($"{a+2*i}, ");
// }
