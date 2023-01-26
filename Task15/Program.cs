// Task 29

Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Содержимое массива: [{string.Join(", ", array)}]");