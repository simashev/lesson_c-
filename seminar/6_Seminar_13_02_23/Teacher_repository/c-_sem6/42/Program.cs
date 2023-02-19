
//Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное.

Console.Clear();
int number = int.Parse(Console.ReadLine());

string res = DecToNum(number, 16);

Console.WriteLine($"{number}->{res}");


//Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}
/*Задача 45: Напишите программу,
 которая будет создавать копию заданного массива с помощью поэлементного копирования.*/

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.

// Если N = 5-> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

// <aside>
// ❗️ Числа Фибоначчи — числовая ****последовательность,
//  каждый элемент которой равен сумме двух предыдущих.