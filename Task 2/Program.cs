/*
Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int[,] Createmassive(int row, int col)
{
    int[,] massive = new int[row, col];
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(1, 10);
        }
    }
    return massive;
}

void Printmassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


int FindSumString(int[,] massive, int i)
{
    int sum = massive[i, 0];
    for (int j = 1; j < massive.GetLength(1); j++)
    {
        sum += massive[i, j];
    }
    return sum;
}


int[,] massive = Createmassive(3, 4);
Printmassive(massive);

int minstr = 0;
int minsum = FindSumString(massive, 0);
for (int i = 1; i < massive.GetLength(0); i++)
{
    int tempsum = FindSumString(massive, i);
    if (tempsum < minsum)
    {
        minsum = tempsum;
        minstr = i;
    }
}
System.Console.WriteLine($"Наименьшая сумма элементов на {minstr+1} строке.");
