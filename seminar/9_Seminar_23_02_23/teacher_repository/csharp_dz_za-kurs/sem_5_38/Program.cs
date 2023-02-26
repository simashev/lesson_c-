// В Указанном массиве фещественных чисел найдите разницу между максимальными и минимальными элементами
Console.WriteLine("Hello, World");

double[] array = { 1.7, 3.6, 2.7, 8.9 };

double[] Res(double[] diff)
{
    double max = diff[0];
    double min = diff[0];
    for (int i = 0; i < diff.Length; i++)
    {
        if (diff[i] > max)
        {
            max = diff[i];
        }
        else if (diff[i] < min)
        {

            min = diff[i];
        }
    }
    Console.WriteLine($"{max}  {min}");
    return new double[] { max, min };
}
double[] newAr = res(array);
Console.WriteLine($"{newAr[0]} - { newAr[1]} = {newAr[0] - newAr[1]}"); 
