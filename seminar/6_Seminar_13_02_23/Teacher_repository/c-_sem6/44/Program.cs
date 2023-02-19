
int[] Fib(int n){
    int[] mas_f = new int[n];
    mas_f[0] = 0;
    if(n >= 2){
        mas_f[1] = 1;
    }else { return mas_f; }
    for (int i = 2; i < n; i++){
        mas_f[i] = mas_f[i - 1] + mas_f[i - 2];
    }
    return mas_f;
}
Console.Clear();
Console.WriteLine("введите N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"[{String.Join(' ', Fib(n))}]");
/***Задача 1:** Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3

**Задача 2:** Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
  задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/