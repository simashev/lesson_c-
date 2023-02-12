//Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
Console.Clear();
int[] array = GetRandomArray(12,-9,10);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] GetRandomArray(int size,int minValue,int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue+1);
    }

    return result;
}