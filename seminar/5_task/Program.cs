Console.Clear ();
Console.Write ("введите число: ");
int a = int.Parse (Console.ReadLine());
int i = -1 * a;
while (i <= a) {
    Console.Write ($"{i}");
    i++;
}
