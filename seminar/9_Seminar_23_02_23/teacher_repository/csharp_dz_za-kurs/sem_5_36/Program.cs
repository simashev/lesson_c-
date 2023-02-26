// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.WriteLine("Hello, World!");
int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine(sum);