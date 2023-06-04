// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// double[,] Create2DRandomArray(int rows, int columns, double minValue, double maxValue)
// {
//     double[,] array = new double[rows, columns];
//     Random random = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             double randomValue = random.NextDouble() * (maxValue - minValue) + minValue;
//             array[i, j] = randomValue;
//         }
//     }

//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void RealArray(double[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);
//     Random random = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = random.Next(-99, 99) / 10.0;
//         }
//     }
// }

// Console.WriteLine("Input number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input min value of array element ");
// double minValue = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input max value of array element ");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// double[,] array = Create2DRandomArray(rows, columns, minValue, maxValue);

// Console.WriteLine("Сгенерированный массив:");
// Print2DArray(array);

// Console.WriteLine("Массив после применения функции RealArray:");
// RealArray(array);
// Print2DArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     Random random = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int ItemPosition(int[,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);
    
//     Console.WriteLine("Введите индекс строки: ");
//     int row = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите индекс столбца: ");
//     int column = Convert.ToInt32(Console.ReadLine());

//     if (row < 0 || row >= rows || column < 0 || column >= columns)
//     {
//         Console.WriteLine("Введенные координаты выходят за границы массива!Такого числа в массиве нет.");
//         return 0;
//     }

//     int element = array[row, column];
//     Console.WriteLine($"Значение элемента: {element}");
//     return element;
// }

// Console.WriteLine("Input number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value of array element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);

// Print2DArray(myArray);

// Console.WriteLine(ItemPosition(myArray));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] =new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


double[] CalculateColumnAverages(int[,] array, int rows, int columns)
{
    double[] columnSums = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double columnSum = 0;
        for (int i = 0; i < rows; i++)
        {
            columnSum += array[i, j];
        }

        columnSums[j] = columnSum / rows;
    }
    
    return columnSums;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i].ToString("0.0") + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array element ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array element ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2DRandomArray(rows, columns, minValue, maxValue);

Print2DArray(array);
double[] columnAverages = CalculateColumnAverages(array, rows, columns);
Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintArray(columnAverages);