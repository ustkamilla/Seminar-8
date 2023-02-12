/*
Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int[,] CreateArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}


int FindSumString(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}


int[,] massive = CreateArray(3, 4);
PrintArray(massive);

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
