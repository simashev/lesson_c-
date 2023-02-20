// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

System.Console.Write("Введи длину массива: ");
int length = int.Parse(Console.ReadLine()!);                    // задаем переменную в которой длина массива, введенная с клавиатуры
int[] dlina = new int[length];                                      // создаем массив

void newArray(int[] array)                                      // функция для заполнения массива
{
    System.Console.Write("Введи минимальное значение массива "); 
    int minValue = int.Parse(System.Console.ReadLine()!);       // переменная в которой минимальное значение элемента массива
    System.Console.Write("Введи минимальное значение массива ");
    int maxValue = int.Parse(System.Console.ReadLine()!);       // переменная в которой максимально значение элемента массива

    for (int i = 0; i < length; i++)                            // цикл, заполняющий наш массив
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();                                 // writeline, чтобы перенестись на новую строку 
                                                                // после выведения элементов массива на экране
}

int GetSum(int[] array)                                // функция для подсчета и вывода суммы нужных элементов
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
}

newArray(dlina);
Console.WriteLine($"Сумма чисел, стоящих на нечетных индексах = {GetSum(dlina)}");