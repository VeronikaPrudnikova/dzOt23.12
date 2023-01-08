// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// 1. Найти минимальное значение в строке. 
// 2. Перенести это значение в конец строки.
// 3. 
/*
int[,] Create2DArray()  
{
    Console.Write("Input a number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());

    

    int[,] array = new int[m,n];
    for(int i = 0; i < m; i++)          
    {
        for(int j = 0; j < n; j++)  
        {
            array[i,j] = i + j;
        }
    }  
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
int[,] SortArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        bool needSort = true;
        while (needSort) 
        {
            needSort = false;
            for(int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if(array[i,j] < array[i,j + 1])
                {
                    int temp = array[i,j + 1];
                    array[i,j + 1] = array[i,j];
                    array[i,j] = temp;
                    needSort = true;
                }
            }
        }
    }
    return array;
}

int[,] myArray = Create2DArray();
Show2dArray(myArray);
int[,] sortArr = SortArray(myArray);
Show2dArray(sortArr);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
void ShowMinSumInRow(int[,] array)
{
    int[] RowsSum = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int summa = 0;
        for(int j = 0; j <array.GetLength(1); j++)
        {
            summa = summa + array[i,j];
        }
        RowsSum[i] = summa;
    }

    int minIndexSum = 0;
    int minSum = RowsSum[0];
    for(int i = 0; i < RowsSum.GetLength(0); i++)
    {
        if(RowsSum[i] < minSum)
        {
            minSum = RowsSum[i];
            minIndexSum = i;
        }
    }
    Console.Write($"номер строки с наименьшей суммой элементов: {minIndexSum}  строкa");
}

int[,] myArray = Create2DArray();
Show2dArray(myArray);
ShowMinSumInRow(myArray);

*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
//  Результирующая матрица будет:
// 18 20
// 15 18
/*
int[,] Create2DArray2()
{
    Console.Write("Enter the number of rows 2 of the matrix: ");
    int m2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the number of columns 2 of the matrix: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    int[,] array2 = new int[m2,n2];
    for(int i2 = 0; i2 < m2; i2++)          
    {
        for(int j2 = 0; j2 < n2; j2++)  
        {
            array2[i2,j2] = i2 + j2;
        }
    }  
    return array2;
}
void Show2dArray2(int[,] array2)
{
    for(int i2 =0; i2 < array2.GetLength(0); i2++)
    {
        for(int j2 = 0; j2 < array2.GetLength(1); j2++)
        {
            Console.Write(array2[i2,j2]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void СompositionIndex(int[,] array, int[,] array2)
{
    int[,] CompositionArray = new int[array.GetLength(0), array.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1); j++)
        {
            int sum = 0;
            for(int i2 =0; i2 < array2.GetLength(0); i2++)
            {
                sum = sum + array[i,i2] * array2[i2,j];
            }
            CompositionArray[i,j] = sum;
        }
    }
    Console.WriteLine($"Результирующая матрица будет:");
    Show2dArray(CompositionArray);
}

int[,] myArray = Create2DArray();
Show2dArray(myArray);

int[,] myArray2 = Create2DArray2();
Show2dArray2(myArray2);

СompositionIndex(myArray, myArray2);
*/ 

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[, ,] Create3DArray()  
{
    Console.Write("Input a number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of  depth : ");
    int k = Convert.ToInt32(Console.ReadLine());

    int[, ,] array = new int[m, n, k];
    
    for(int i = 0; i < m; i++)          
    {
        for(int j = 0; j < n; j++)
        {
            for(int p = 0; p < k; p++)
            {
                int newValue = new Random().Next(10, 99);
                while(CheckValueInArray(array, newValue))
                {
                    newValue = new Random().Next(10, 99);
                }
                array[i,j,p] = newValue;
            }
        }
    }  
    return array;
}

bool CheckValueInArray(int[,,] array, int value)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int p = 0; p < array.GetLength(2); p++)
            {
                if(value == array[i,j,p])
                {
                    return true;
                }
            }
        }
    }
    return false;
}

void Show3dArray(int[, ,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int p = 0; p < array.GetLength(2); p++)
            {
                Console.WriteLine($"{array[i,j,p]} ({i},{j},{p})");
            }
        }
    }
    Console.WriteLine();
}


int[,,] myArray = Create3DArray();
Show3dArray(myArray);
*/

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] Create2DArray()  
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];
    int counter = 1;
    int cycle = 0;

    for(int j = 0; j < columns; j++)
    {
        array[cycle,j] = counter;
        counter++;
    }
    for(int p = cycle+1; p < rows; p++) 
    {
        array[p,columns-1] = counter;
        counter++;
    }
    for(int j = columns-2; j >= 0; j--)
    {
        array[rows-1, j] = counter;
        counter++;
    } 
    for(int i = rows-1; i > 0; i--)
    {
        array[i, cycle] = counter;
        counter++;
    } 
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 10)
            {
                Console.Write("0" + array[i,j]+ " ");
            }
            else
            {
                Console.Write(array[i,j]+ " ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] myArray = Create2DArray();
Show2dArray(myArray);