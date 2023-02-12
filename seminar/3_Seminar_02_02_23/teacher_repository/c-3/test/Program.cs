Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int i = num / 10000;
int b = num % 10;

if (i == b)
{
    Console.WriteLine("Является палиндромом");
}
else
{
    Console.WriteLine("Не является палиндромом");
}