// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/* int[,] Create2dArray (int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i=0; i<array.GetLength(0); i++)
        for (int j = 0; j< array.GetLength(1); j++)
            array[i,j] = new Random().Next(0,10);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1)-1; j++)
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                 if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
}
Console.Write(" Input a rows of array" + " ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a colums of array" + " ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] myarray = Create2dArray(rows, colums);
Show2dArray(myarray);
Console.WriteLine("Sort array");
SortArray(myarray);
Show2dArray(myarray); */

/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет
 находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] Create2DArray(int row, int colom)
{
    int[,] array=new int [row, colom];
    for( int i=0; i<row; i++)
        for (int j=0; j < colom; j++)
            array[i,j] = new Random().Next(-10,10);
    return array;
}

void Show2dArray (int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " " );
        Console.WriteLine();
    }
}

int FindeRowMinSum(int[,] array)
{
    int minSum = 0;
    int rowIndex = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            rowIndex = i;
        }
    }
    return rowIndex;
}
Console.Write(" Input a rows of array" + " ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a colums of array" + " ");
int colum = Convert.ToInt32(Console.ReadLine());

int[,] myarray = Create2DArray(row, colum);
Show2dArray(myarray);
Console.Write($"Номер строки в массиве с минимальной суммой элементов {FindeRowMinSum(myarray)}");