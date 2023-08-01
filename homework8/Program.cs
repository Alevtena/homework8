// Task 1 . Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

/* Task 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет
 находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

/* int[,] Create2DArray(int row, int colom)
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
Console.Write($"Номер строки в массиве с минимальной суммой элементов {FindeIndex(newarray)}"); */

/* Task 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

/* int[,] Create2dArray (int row, int colum)
{
    int [,] array = new int[row, colum];
    for (int i=0; i<row; i++)
        for (int j=0; j<colum; j++)
            array[i,j] = new Random().Next(0,10);
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
bool Proverka (int colum1, int row2) // проверяем условие для возможности умножения матриц
{
    if ( colum1==row2) 
        return true;
    else return false;
}
int[,] MultiplicateArray(int[,] firstarray , int [,] secondarray, int row1, int colum1, int row2, int colum2)
// метод умножения матриц при выполнении условия равенства солбцов 1 матрицы = строки 2 матрицы 
{
    int [,] resultarray = new int[row1, colum2];
        for (int i=0; i<row1; i++)
            for (int j=0; j<colum2; j++)
            {
                int sum = 0;
                for (int k=0; k<colum1; k++)
                    sum += firstarray[i,k]*secondarray[k,j];
            resultarray[i,j] = sum;
            }
    return resultarray; 
}

Console.Write(" Input a rows of firstarray" + " ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a colums of firstarray" + " ");
int colum1 = Convert.ToInt32(Console.ReadLine());

Console.Write(" Input a rows of secondarray" + " ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a colums of secondarray" + " ");
int colum2 = Convert.ToInt32(Console.ReadLine());

int[,] firstarray = Create2dArray(row1, colum1);
int[,] secondarray = Create2dArray(row2, colum2);
Show2dArray(firstarray);
Console.WriteLine();
Show2dArray(secondarray);
bool temp = Proverka(colum1,row2);
if (temp==true)
{
    int[,] resultarray = MultiplicateArray(firstarray, secondarray, row1, colum1, row2, colum2);
    Console.WriteLine("Произведение матриц");
    Show2dArray(resultarray);
}
else Console.WriteLine("Умножение невозможно. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");
*/
/* Task 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) 

массив трехмерный сформирован, выводитмся на экран. Однако нет проверки повторяющихся чисел. (не знаю как !!!)
*/

 int[, ,] Create3dArray(int row, int colum, int h, int minvalue, int maxvalue)
{
    int[, , ] array = new int[row,colum,h];
    int[] numarray = new int[row*colum*h];
    for (int i=0, m=0; i<row; i++, m++)
    {
        for (int j=0; j<colum; j++)
        {
            for (int k=0; k<h; k++)
            {
                Console.Write($"Введите  элемент массива в виде двузначного числа {i}, {j},{k}: ");
                array[i,j,k] = Convert.ToInt32(Console.ReadLine());
                numarray[m]=array[i,j,k];
            }
        }
        
    }
    return array;
}

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} [{i},{j},{k}]   ");
            Console.WriteLine();
        }
    }
}

Console.Write(" Input a rows of array" + " ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a colums of array" + " ");
int colum = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a h of array" + " ");
int h = Convert.ToInt32(Console.ReadLine());

Console.Write(" Input a minvalue of array" + " ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.Write(" Input a maxvalue of array" + " ");
int maxvalue = Convert.ToInt32(Console.ReadLine());
int[,,] myarray = Create3dArray(row,colum,h,minvalue,maxvalue);
Show3DArray(myarray);


// Task 5. Напишите программу, которая заполнит спирально массив 4 на 4. 
/* Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

/* int[,] CreateArray(int row =4, int colum=4)
{
    int[,] array = new int[row, colum];

    int value = 1;              
    int minRow = 0;
    int maxRow = 3;
    int minCol = 0;
    int maxCol = 3;

    while (value <= 16)
    {
        for (int i = minCol; i <= maxCol; i++) //вправо
        {
            array[minRow, i] = value;
            value++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++) //вниз
        {
            array[i, maxCol] = value;
            value++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--) //влево
        {
            array[maxRow, i] = value;
            value++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--) //вверх
        {
            array[i, minCol] = value;
            value++;
        }
        minCol++;
    }
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            if (array[i,j]<10) Console.Write($"0{array[i,j]} ");
            else Console.Write(array[i,j] + " ");
        }
        
        Console.WriteLine();
    }
}
int [,] myarray = CreateArray(4,4);
Show2dArray(myarray); */