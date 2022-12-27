// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void ArithmeticMeanColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {    
        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = (array[i,j] + summ);
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j+1} = { Math.Round(summ/array.GetLength(0), 1)}");
    } 
}
    
void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int[,] array = FillArray(3, 4, 1, 10);
PrintArr(array);
ArithmeticMeanColumn(array);