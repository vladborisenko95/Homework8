//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int InputData(string message)
{
    Console.Write(message);
    int d = int.Parse(Console.ReadLine());
    return d;
}

bool IsValidSizeArray(int rows, int colums)
{
    return (rows > 0 && colums > 0);
}

int[,] FillArray(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
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
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

int[,] SortRowArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k + 1] > array[i, k])
                {
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    return array;
}

int rows = InputData("Введите количество строк массива ");
int colums = InputData("Введдите количество столбцов массива ");
int min = InputData("Введите минимальное значение элемента массива ");
int max = InputData("Введите максимальное значение элемента массива ");
if (IsValidSizeArray(rows, colums))
{
    int[,] Array = FillArray(rows, colums, min, max);
    PrintArray(Array);
    Console.WriteLine();
    Console.WriteLine();
    Array = SortRowArray(Array);
    PrintArray(Array);
}
else Console.WriteLine("Ошибка");

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int InputData(string message)
{
    Console.Write(message);
    int d = int.Parse(Console.ReadLine());
    return d;
}

bool IsValidSizeArray(int rows, int colums)
{
    return (rows > 0 && colums > 0);
}

int[,] FillArray(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine("sumRow" + (i + 1) + "=" + sumRow);
    }
}

int IndexRowMinSum(int[,] array)
{
    int sumRow = 0;
    int minSumRow = 0;
    int indexMinSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSumRow += array[0,j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i,j];
        }
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            indexMinSum = i;
        }
    }
    return indexMinSum;
}

int rows = InputData("Введите количество строк массива ");
int colums = InputData("Введдите количество столбцов массива ");
int min = InputData("Введите минимальное значение элемента массива ");
int max = InputData("Введите максимальное значение элемента массива ");
if (IsValidSizeArray(rows, colums))
{
    int[,] array = FillArray(rows, colums, min, max);
    PrintArray(array);
    int rowMinSum = IndexRowMinSum(array);
    Console.WriteLine("Минимальная сумма элементов в строке " + (rowMinSum+1));
}
else Console.WriteLine("Ошибка ввода");

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int InputData(string message)
{
    Console.Write(message);
    int d = int.Parse(Console.ReadLine());
    return d;
}

bool IsValidSizeArray(int rows, int colums)
{
    return (rows > 0 && colums > 0);
}

bool IsValidMultliplicationArray(int columsA, int rowsB)
{
    return (columsA == rowsB);
}

int[,] FillArray(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
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
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationArray(int[,] arrayA, int[,] arrayB)
{
    int[,] MultiArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < MultiArray.GetLength(0); i++)
    {
        for (int j = 0; j < MultiArray.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                temp += arrayA[i,k] * arrayB[k,j];
            }
            MultiArray[i,j] = temp; 
        }
    }
    return MultiArray;
}

int rowsA = InputData("Введите количество строк массива A ");
int columsA = InputData("Введдите количество столбцов массива A ");
int rowsB = InputData("Введите количество строк массива B ");
int columsB = InputData("Введдите количество столбцов массива B ");
int min = InputData("Введите минимальное значение элемента массива ");
int max = InputData("Введите максимальное значение элемента массива ");
if (IsValidSizeArray(rowsA, columsA) && IsValidSizeArray(rowsB, columsB))
{
    int[,] ArrayA = FillArray(rowsA, columsA, min, max);
    int[,] ArrayB = FillArray(rowsB, columsB, min ,max);
    PrintArray(ArrayA);
    Console.WriteLine();
    PrintArray(ArrayB);
    Console.WriteLine();
    if (IsValidMultliplicationArray(columsA, rowsB))
    {
        int[,] multiArray = MultiplicationArray(ArrayA, ArrayB);
        PrintArray(multiArray);
    }
}

//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int InputData(string message)
{
    Console.Write(message);
    int d = int.Parse(Console.ReadLine());
    return d;
}

bool IsValidSizeArray(int module, int rows, int colums)
{
    return (module > 0 && rows > 0 && colums > 0);
}

int[,,] FillArray(int module, int rows, int colums, int min, int max)
{
    int[,,] array = new int[module, rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(min, max);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int moduleA = InputData("Введите количество модулей массива A ");
int rowsA = InputData("Введите количество строк массива A ");
int columsA = InputData("Введдите количество столбцов массива A ");
int min = InputData("Введите минимальное значение элемента массива ");
int max = InputData("Введите максимальное значение элемента массива ");
if (IsValidSizeArray(moduleA, rowsA, columsA))
{
    int[,,] array = FillArray(moduleA, rowsA, columsA, min, max);
    PrintArray(array);
}
else Console.WriteLine("Ошибка");

//Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.

int InputData(string msg)
{
    Console.Write(msg);
    int data = int.Parse(Console.ReadLine());
    return data;
}

bool IsValid(int side)
{
    return (side > 0);
}

int[,] FillSnailArray(int side)
{
    int[,] snailArray = new int[side, side];
    int temp = 1;
    int x = 0;
    int y = 0;
    int w = 0;
    int m = side;
    for (int i = 0; i < m; i++)
    {
        //вправо
        for (int j = 0; j < m - w; j++)
        {
            snailArray[i, j + w] = temp;
            temp++;
            if (j + w == m - 1)
            {

                //вниз
                for (int k = w + 1; k < m; k++)
                {
                    snailArray[k, j + w] = temp;
                    temp++;
                    if (k == m - 1)
                    {

                        // влево
                        for (int l = m - (w + 2); l >= x; l--)
                        {
                            snailArray[k, l + w] = temp;
                            temp++;
                            if (l == 0)
                            {

                                // вверх
                                for (int n = m - 2; n > 0 + w; n--)
                                {
                                    snailArray[n, l + w] = temp;
                                    temp++;

                                }
                                
                                
                            }
                        }
                    }
                }
            }
        }
        m--;
        
        w++;

    }
    return snailArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

int sideA = InputData("Введите сторону массива A ");
if (IsValid(sideA))
{
    int[,] snailArray = FillSnailArray(sideA);
    PrintArray(snailArray);