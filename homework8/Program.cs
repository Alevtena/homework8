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
            array[i,j] = new Random().Next(0,10);
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
void ShowArray (int[] newarray) // выводит одномерный массив с суммами по строкам
{
    for(int i=0; i < newarray.Length; i++)
    {
        Console.Write(newarray[i] + ", " );
    }
}
int[] RowsSum(int[,] array, int row, int colum) // считает сумму в массиве по строчкам и записывает одномерный массив изэтих сумм
{
    int[] newarray  = new int [row];
    for (int i=0; i<row; i++)
    {
        int sumrow = 0; 
        for (int j=0; j < colum; j++)
        {
        sumrow += array[i,j];
        newarray[i] = sumrow;
        }
    }
    return newarray;
}
int FindeIndex (int[] newarray) // находит номер строки с минимальной суммой
{
    int min = newarray[0];
    int index = 0;
    for (int i = 1; i < newarray.Length; i++)
    {
        if (newarray[i] < min)
        {
            min = newarray[i];
            index = i;
        }
    }
    return (index +1);
}
Console.Write(" Input a rows of array" + " ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a colums of array" + " ");
int colum = Convert.ToInt32(Console.ReadLine());

int[,] myarray = Create2DArray(row, colum);
Show2dArray(myarray);
int [] newarray = RowsSum(myarray, row, colum);
Console.WriteLine("Сумма элементов в каждой строке массива");
ShowArray(newarray);
Console.WriteLine();
Console.Write($"Номер строки в массиве с минимальной суммой элементов {FindeIndex(newarray)}");