// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел 
Console.Clear();

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int counteven = 0;
int countOdd = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        counteven = countEven + 1;
    }
    else
    {
        countOdd = countOdd + 1;
    }
}

Console.WriteLine("Even numbers = " + countEven);
Console.WriteLine("Odd numbers = " + countOdd);