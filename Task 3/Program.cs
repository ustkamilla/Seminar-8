/*
Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

int[,] MultiplicationArray(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
    return resultArray;
}

int[,] massive = CreateArray(3, 4);
PrintArray(massive);
System.Console.WriteLine();
int[,] massive2 = CreateArray(4, 3);
PrintArray(massive2);
System.Console.WriteLine();
if (massive.GetLength(1) == massive2.GetLength(0))
{
    int[,] multip = MultiplicationArray(massive, massive2);
    PrintArray(multip);
}
else
{
    System.Console.WriteLine("Невозможно вычислить произведение данных матриц.");
}
