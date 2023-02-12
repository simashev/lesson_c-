Console.Clear ();
Console.Write ("введите число: ");
int a = int.Parse (Console.ReadLine());
if (a < 100 || a > 999){
    Console.WriteLine("Введено не правильное число");
    return;
}
int otvet = a % 10;
Console.WriteLine($"3 цифра {otvet}");

Console.WriteLine("-------------");
Console.WriteLine("Второй метод");
string a2 = Console.ReadLine();
string otvet2 = Convert.ToString(a2[a2.Length - 1]);
Console.WriteLine($"3 цифра {otvet2}");
