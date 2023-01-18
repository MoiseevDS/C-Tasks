// Задача 15 является ли день выходным 
Console.Clear();
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 7 || day == 6)
    Console.WriteLine("Выходной день!!!");
else
    Console.WriteLine("Будний день");

