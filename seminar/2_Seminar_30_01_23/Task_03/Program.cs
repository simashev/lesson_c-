// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно


// Console.Clear();

// Console.Write("Первое число ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Второе число ");
// int b = int.Parse(Console.ReadLine());
// int result = a % b;
// if (result == 0){
// 	Console.WriteLine("Кратно");
// }
// else{
// 	Console.WriteLine($"Остаток {result}");
// }


Console.Clear();
Console.Write("Введите 1-ое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1%number2==0) {
  Console.WriteLine("Кратно");
}
else {
  Console.Write($"Не кратно, остаток {number1 % number2} ");
}