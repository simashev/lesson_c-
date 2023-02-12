//Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.

// Console.Clear();

// int num = new Random().Next(100,1000);
// Console.WriteLine($"Num={num}");
// int posl = num%10;
// int perv = num/100;
// Console.WriteLine($"Perv={perv}");
// Console.WriteLine($"posl={posl}");
// int perv10=perv*10;
// int result = perv10 + posl;
// Console.WriteLine($"result={result}");

//Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.

Console.Clear();

int num = new Random().Next(100,1000);
int result = (num / 100) * 10 + num % 10;
Console.WriteLine($"{num} -> {result}");
Console.WriteLine($"{num} -> {num/100}{num%10}");