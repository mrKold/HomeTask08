// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший 
// элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int positionX = 0;
    int positionY = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if (min >= matrix[i, j])
                {
                    min = matrix [i, j];
                    positionX = i;
                    positionY = j;
                }
            }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != positionX)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != positionY)
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}


Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Начальный массив: \n");
InputMatrix(matrix);
Console.WriteLine("Конечный массив: \n");
ReleaseMatrix(matrix);