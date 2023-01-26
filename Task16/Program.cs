// Суперсдвиг

Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите значение: ");
int k = Convert.ToInt32(Console.ReadLine());

if (k < 0)
{
    k = -k;
    k %= n;
}
else
{
    k %= n;
    k = n - k;
}

for (int i = k; i < n; i++)
    Console.Write($"{array[i]}, ");
for (int i = 0; i < k; i++)
    Console.Write($"{array[i]}, ");