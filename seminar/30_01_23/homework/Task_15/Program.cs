// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear ();
Console.Write ("введите номер дня недели: ");
int a = int.Parse (Console.ReadLine());
if (a < 1 || a > 7) 
{
    Console.WriteLine ("введен неправильный номер: ");
    return;
}
if (a <= 5)
{
     Console.WriteLine ("нет");
}
if (a > 5)
{
     Console.WriteLine ("да");
}