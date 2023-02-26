// Показать двумерный массив размером m×n заполненный вещественными числами
int m = 3;
int n = 4;

double[,] array = new double[m, n];

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble();
        }
    }
}

void Print(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");

        }
        Console.WriteLine();
    }
}
FillArray(array);
Print(array);