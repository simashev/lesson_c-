// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


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