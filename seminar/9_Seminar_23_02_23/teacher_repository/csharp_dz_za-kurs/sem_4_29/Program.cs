// Задать массив из 8 элементов и вывести их на экран
Console.WriteLine("введите элементы массива");

//int num = int.Parse(Console.ReadLine());

int[] array = new int[8];
int len = array.Length;
int index = 0;
while (index < len)
{
    array[index] = int.Parse(Console.ReadLine()); ;
    index++;
}
for (int i = 0; i < len; i++)
{
    Console.Write(array[i]);
}