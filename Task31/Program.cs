// Task 58

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); // [1, 9]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine("");
    }
}


static int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(0) == matrix2.GetLength(1))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
                Console.Write($"{matrix3[i, j]} \t");
            }
            Console.WriteLine("");
        }
    }
    return matrix3;
}


Console.Write("Введите размеры 1го массива: ");
int[] size1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
Console.Write("Введите размеры 2го массива: ");
int[] size2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
InputMatrix(matrix1);
Console.WriteLine("");
InputMatrix(matrix2);
Console.WriteLine("");
DivMatrix(matrix1, matrix2);

