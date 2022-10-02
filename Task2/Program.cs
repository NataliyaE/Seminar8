// прямоугольный массив. написать прогу, которая будет находить строку с наимен суммой элементов


Console.WriteLine("Pls input number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls input number of columns (not equal to rows)");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

Console.WriteLine();
CreateArray(array);
PrintArray(array);
Console.WriteLine();

void CreateArray(int[,] array)
{
    for (int  i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int  i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

/*
if (rows == columns)
{
    Console.WriteLine("The array is not correct");
}
else
{
    FindSumLineElements(array, i);
}
*/

int FindSumLineElements(int[,] array, int i)
   {
       int sumLine = array[i, 0];
       for (int j = 0; j < array.GetLength(1); j++)
           {
               sumLine += array[i,j]; 
           }
       return sumLine;
   }

int MinSumLine = 0;
int sumLine = FindSumLineElements (array, 0);
for (int i = 0; i < array.GetLength(0); i++)
{
    int temp = FindSumLineElements(array, i);
    if (sumLine > temp)
    {
            sumLine = temp;
            MinSumLine = i;
    }
}

Console.WriteLine($"The line with min sum of Elements = {MinSumLine}");
