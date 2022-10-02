// задать двум массив. прога упорядочивает по убыванию элементы каждой строки

Console.WriteLine("Pls input number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Pls input number of columns");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

Console.WriteLine();
CreateArray(array);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);

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

void SortArray(int[,] array)
{
    for (int  i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if(array[i,k] < array[i,k+1])
                {
                    temp = array[i, k+1];
                    array[i, k+1] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}
