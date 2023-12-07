using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine());

        int value = GetValue(array, row, column);

        if (value != -1)
        {
            Console.WriteLine($"Значение элемента: {value}");
        }
        else
        {
            Console.WriteLine("Элемента с указанными позициями не существует");
        }
    }

    static int GetValue(int[,] array, int row, int column)
    {
        int rowsCount = array.GetLength(0);
        int columnsCount = array.GetLength(1);

        if (row >= 0 && row < rowsCount && column >= 0 && column < columnsCount)
        {
            return array[row, column];
        }
        else
        {
            return -1; // Возвращаем -1, чтобы показать, что элемента с указанными позициями не существует
        }
    }
}
