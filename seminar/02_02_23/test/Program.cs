Console.Write ("введи строку b = ");
string b = Console.ReadLine();

Console.Write ("Введите длину строки = ");
int m = int.Parse(Console.ReadLine());

char[] a =  new char[m];
a = b.ToCharArray(0,b.Length);
Console.Write($"{a.ToString()}");
