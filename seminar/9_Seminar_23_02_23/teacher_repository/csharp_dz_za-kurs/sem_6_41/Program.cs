// 42. Определить сколько чисел больше 0 введено с клавиатуры

// System.Console.Write("Enter the numbers: ");
// String word = Console.ReadLine();
// string[] finished = word.Split(' ');
// Console.WriteLine(String.Join(',', finished));
// int EnterNumber = Int32.Parse(word);

System.Console.Write("Enter the numbers: ");
String numb = Console.ReadLine();
string[] Numbers = numb.Split(' ');
int[] ConvertNumbers = new int[Numbers.Length];
for (int i = 0; i < Numbers.Length; i++)
{
    ConvertNumbers[i] = Int32.Parse(Numbers[i]);
}
int GetCountOfPosNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;

        }
    }
    return count;
}
System.Console.Write("Numbers greater than 0 entered times: ");
System.Console.WriteLine(GetCountOfPosNumbers(ConvertNumbers));