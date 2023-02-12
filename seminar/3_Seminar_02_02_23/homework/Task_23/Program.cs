// Задача 23

// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Вывод только при вводе числа от 1 до N
Console.Clear();
Console.Write("Введи число N = ");
int N = int.Parse (Console.ReadLine());

if (N <= 0) {
   Console.Write("Введено неверное число"); 
   return;
}
double[] result = new double [N];

for(int i = 0; i < N;i++){
    result[i] = (Math.Pow(i + 1, 3));
    Console.Write($"{result[i]} ");
}

// // отрицательные - вывод с положительными 
// Console.Clear();
// Console.Write("Введи число N = ");
// int N = int.Parse (Console.ReadLine());

// int m = N;
// if (N <= 0) {
//    m = - N;
// }
// double[] result = new double [m];

// for(int i = 0; i < m;i++){
//     result[i] = (Math.Pow(i + 1, 3));
//     Console.Write($"{result[i]} ");
// }

// // отрицательные - вывод с отрицательными 
// Console.Clear();
// Console.Write("Введи число N = ");
// int N = int.Parse (Console.ReadLine());

// int m = N;
// if (N <= 0) {
//     m = - N*2+1; //3
//    //Console.Write($"{m}");
//    // return; -1
//     double[] result = new double [m];
//     for (int i = 0; i < m; i++){
//         result[i] = Math.Pow(N, 3);
//         N++;
//         Console.Write($"{result[i]} ");
//     }

// }   
// else{
// double[] result = new double [m];
// //Console.Write($"{m} ");
// for(int i = 0; i < m;i++){
//     result[i] = (Math.Pow(i + 1, 3));
//     Console.Write($"{result[i]} ");
// }
// }