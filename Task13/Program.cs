// Задача 25

Console.Clear();
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());
int degree = b;

for (int i = 1; i < n; i++)
    degree = degree * b;

Console.WriteLine(degree);

