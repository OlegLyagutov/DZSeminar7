﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] array = new double[rows, columns];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array[i, j] = new Random().Next(10);
//         Console.Write(array[i,j] + "\t");
//     }
// Console.WriteLine();   
// }



// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, columns];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array[i, j] = new Random().Next(10);
//         Console.Write(array[i,j] + "\t");
        
//     }
// Console.WriteLine(); 
// }
// Console.Write("Введите позицию элемента строки (i): ");
// int positionRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию элемента столбца (j): ");
// int positionColumns = Convert.ToInt32(Console.ReadLine());

// if (positionRows > rows || positionColumns > columns)
// Console.WriteLine($"такого числа в массиве нет");


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int meanArithmetic = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i,j] + "\t");
        if (j < ) meanArithmetic += array[i,j] / i;
    }
Console.WriteLine(); 

 

Console.WriteLine($"Среднее арифметическое каждого столбца: {meanArithmetic}");
}


