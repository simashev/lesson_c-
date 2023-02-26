// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("введите число A");

int A = int.Parse(Console.ReadLine());

Console.WriteLine("введите число B");

int B = int.Parse(Console.ReadLine());

int comp = 1;

for (int i = 1; i <= B; i++)
{
    comp = comp * A;
}
Console.WriteLine(comp);