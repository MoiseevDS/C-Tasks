// Task 38

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(Console.ReadLine());
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
double max = array[0], min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
    else if (array[i] < min)
        min = array[i];
}

Console.WriteLine($"Разница между min и max: {(max - min)}");

