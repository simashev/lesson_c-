Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

switch (quarter)
{
    case 1:
        {
            Console.WriteLine("x>0 y>0");
            break;
        }
    case 2:
        {
            Console.WriteLine("x<0 y>0");
            break;
        }
    case 3:
        {
            Console.WriteLine("x<0 y<0");
            break;
        }
    case 4:
        {
            Console.WriteLine("x>0 y<0");
            break;
        }
    default:
        {
            Console.WriteLine("Введена неправильная четверть");
            break;
        }
}
// Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

