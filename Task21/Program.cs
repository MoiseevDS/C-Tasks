// Task additional ACMP Task 5

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int coun1 = 0, coun2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        Console.Write($"{array[i]} ");
        coun1++;
    }
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
        coun2++;
    }
}
Console.WriteLine();
if (coun1 > coun2)
    Console.WriteLine("No");
else
    Console.WriteLine("Yes");