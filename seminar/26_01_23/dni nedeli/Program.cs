
Console.Clear ();
Console.Write ("введите номер дня недели: ");
int a = int.Parse (Console.ReadLine());
if (a < 1 || a > 7) 
{
    Console.WriteLine ("введен неправильный номер: ");
    return;
}
if (a == 1)
{
     Console.WriteLine ("Понедельник");
}
if (a == 2)
{
     Console.WriteLine ("Вторник");
}if (a == 1)
{
     Console.WriteLine ("Понедельник");
}if (a == 3)
{
     Console.WriteLine ("Среда");
}if (a == 4)
{
     Console.WriteLine ("Четверг");
}if (a == 5)
{
     Console.WriteLine ("Пятница");
}if (a == 6)
{
     Console.WriteLine ("Суббота");

}
