// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.Write ("Введите число A: ");
int A = int.Parse (Console.ReadLine ());
Console.WriteLine($"Cумма чисел {A} равна {CountNumbers(A)}");

int CountNumbers(int n) //123
{
    int count = 0; // count 0
    if (n < 0)
        n *= (-1); // n = n * (-1) 
    while (n > 0) // 0 > 0
    {
        n /= 10; // n = n / 10    n = 0
        count++; // count 3
        
    }
    
    return count;
}

{
    if 
}