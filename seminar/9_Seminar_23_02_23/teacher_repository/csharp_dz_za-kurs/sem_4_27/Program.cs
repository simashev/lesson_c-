// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());
int res = 0;
int b = 0;
while (a > 0)
{
    b = a % 10;
    res = res + b;
    a = a / 10;


}


Console.WriteLine(res);