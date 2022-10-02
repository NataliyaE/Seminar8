/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/



Console.WriteLine("Pls input number of rows");
int rowsFirstArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls input number of columns");
int columnsFirstArray = Convert.ToInt32(Console.ReadLine());

int rowsSecondArray = columnsFirstArray;
int columnsSecondArray = rowsFirstArray;

int[,] arrayFirst = new int[rowsFirstArray, columnsFirstArray];
int[,] arraySecond = new int[rowsSecondArray, columnsSecondArray];
int[,] arrayMultiply = new int [rowsFirstArray, columnsSecondArray];

Console.WriteLine();
CreateArrayFirst(arrayFirst);
PrintArrayFirst(arrayFirst);
Console.WriteLine();
CreateArraySecond(arraySecond);
PrintArraySecond(arraySecond);
Console.WriteLine();
CreateArrayMultiply(arrayFirst, arraySecond, arrayMultiply);
PrintArrayMultiply(arrayMultiply);

void CreateArrayFirst(int[,] arrayFirst)
{
    for (int  i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFirst.GetLength(1); j++)
        {
            arrayFirst[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArrayFirst(int[,] arrayFirst)
{
    for (int  i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFirst.GetLength(1); j++)
        {
            Console.Write(arrayFirst[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void CreateArraySecond(int[,] arraySecond)
{
    for (int  i = 0; i < arraySecond.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            arraySecond[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArraySecond(int[,] arraySecond)
{
    for (int  i = 0; i < arraySecond.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            Console.Write(arraySecond[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void CreateArrayMultiply(int[,] arrayFirst, int[,] arraySecond, int[,] arrayMultiply)
{
    for (int  i = 0; i < arrayMultiply.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMultiply.GetLength(1); j++)
        {
            int newElement=0;
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                newElement += arrayFirst[i, k] * arraySecond[k, j];
            }
            arrayMultiply[i, j] = newElement;
        }
    }
}

void PrintArrayMultiply(int[,] arrayMultiply)
{
    for (int  i = 0; i < arrayMultiply.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMultiply.GetLength(1); j++)
        {
            Console.Write(arrayMultiply[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

