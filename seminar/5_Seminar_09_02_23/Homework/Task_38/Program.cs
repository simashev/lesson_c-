// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
double[] Array = GetArray(5, 5, 2);
Console.WriteLine(String.Join(" ", Array));
Console.WriteLine($"Разница = {GetDifference(Array)}");

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return res;
}

double GetDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    Console.WriteLine($"минимальный элемент {min}");
    Console.WriteLine($"максимальный элемент {max}");
    return max - min;
}

// --- 
// // Задайте массив вещественных чисел.
// // Найдите разницу между максимальным и минимальным элементов массива.

// Console.Clear();

// System.Console.Write("Enter the array length: ");
// int length = int.Parse(Console.ReadLine()!);                    // задаем переменную в которой длина массива, введенная с клавиатуры
// double[] A = new double[length];                                      // создаем массив
// newArray(A);
// Console.WriteLine($"Разность между максисальным и минимальным элементами = {GetMaxMinusMin()}");

// void newArray(double[] array)                                      // функция для заполнения массива вещ. числами
// {
//     // System.Console.Write("Enter min Value of array: "); 
//     // int minValue = int.Parse(System.Console.ReadLine()!);       // переменная в которой минимальное значение элемента массива
//     // System.Console.Write("Enter max Value of array: ");
//     // int maxValue = int.Parse(System.Console.ReadLine()!);       // переменная в которой максимально значение элемента массива

//     for (int i = 0; i < length; i++)                            // цикл, заполняющий наш массив
//     {
//         System.Console.Write($"Введите элемент под индексом {i}: "); // введение вещественных элементов с клавиатуры
//         array[i] = Convert.ToDouble(Console.ReadLine());
//         // System.Console.Write($"{array[i]} ");
//     }
// }

// double GetMinElement(double[] array)                               // функция для нахождения минимального элемента
// {
//     double min = array[0];
//     for(int i = 0; i < length; i++)
//     {
//         if (array[i] < min) min = array[i];
//     }
//     return min;
// }

// double GetMaxElement(double[] array)                                // функция для нахождения минимального элемента
// {
//     double max = array[0];
//     for(int i = 0; i < length; i++)
//     {
//         if (array[i] > max) max = array[i];
//     }
//     return max;
// }

// double GetMaxMinusMin()                                             // функция для нахождения разности максимального и минимального элементов
// {
//     double result = GetMaxElement(A) - GetMinElement(A);
//     return result;
// }