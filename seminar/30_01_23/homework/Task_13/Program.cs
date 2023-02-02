// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write ("Введите любое число ");
int a = Int32.Parse(Console.ReadLine());
if (a < 100) {
    Console.WriteLine("Число меньше 100");
}else {
    while (a > 1000) {
        a /= 10; // a=a / 10
    }
      Console.WriteLine(a%10);
}
