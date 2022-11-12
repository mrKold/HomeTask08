// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

bool checkNumberInArray(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
            return false;
    }
    return true;
}


int InputMatrix(int[,] matrix, int[] arrayHelp)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            if (checkNumberInArray(arrayHelp, matrix[i, j]))
            {
                arrayHelp[k] = matrix[i, j];
                k++;
            }
        }
    }
    return k;
}

void ReleaseMatrix(int[,] matrix, int[] array, int counts)
{
    int[] arrayHelp = new int[counts + 1];
    for (int i = 0; i <= counts; i++)
    {
        arrayHelp[i] = array[i];
    }
    for (int k = 0; k < arrayHelp.Length; k++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (arrayHelp[k] == matrix[i, j])
                    count++;
            }
        }
        Console.WriteLine($"Значение {arrayHelp[k]} встречается {count} раз");
    }
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
int[] arrayHelp = new int[n * m];
Console.WriteLine("Начальный массив: \n");
int k = InputMatrix(matrix, arrayHelp);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] + " \t");
    Console.WriteLine();
}
ReleaseMatrix(matrix, arrayHelp, k);