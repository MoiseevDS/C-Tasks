// Task 36

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
int sumNotEven = 0;

for (int i = 1; i < array.Length; i = i + 2)
    sumNotEven += array[i];

Console.WriteLine($"Сумма чисел нечетных элементов: {sumNotEven}");
