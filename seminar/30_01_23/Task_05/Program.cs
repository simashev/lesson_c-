// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.Clear();
Console.Write("Введите 1-ое число: ");
int num1 = int.Parse(Console.ReadLine());
int ost7 = (num1 % 7);
int ost23 = (num1 % 23);
if (ost7==0 && ost23==0) {
  Console.WriteLine("Да");
}
else {
  Console.Write($"Нет ");
}