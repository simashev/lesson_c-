//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.
Console.Clear();
 Console.Write("Введите число: ");
 int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");
int num1 = 2;
Console.WriteLine($"Произведение цифр = {GetMultiply(num1)}");
int num2 = 3;
Console.WriteLine($"Произведение цифр = {GetMultiply(num2)}");
int num3 = 4;
Console.WriteLine($"Произведение цифр = {GetMultiply(num3)}");

int GetMultiply(int n){ // n=3
    int result = 1;
    for (int i = 2; i <= n; i++){ // i <= n; 2 <= 3
        result *= i; // result
    }
    return result;
}
//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// Random r = new Random();
// int a = r.Next(0, 2);
// int a = r.Next(2, 10);
// int a = r.Next(2);