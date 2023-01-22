// Дополнительное задание Сбор черники

Console.Clear();
Console.Write("Введите колличество кустов черники: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n + 2];
int sum = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Число ягод черники на кусте: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
    a[n] = a[0];
    a[n + 1] = a[1];
}
for (int i = 1; i < n + 1; i++)
{
    int sum1 = a[i - 1] + a[i] + a[i + 1];
    if (sum1 > sum)
        sum = sum1;
}
Console.WriteLine($"Максимальное колличество ягод: {sum}");