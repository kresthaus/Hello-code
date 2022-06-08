// Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 -> Среда -> Пятница

Console.Write("Введите число => "); // Это вывод на экран приглашения
string paramString = Console.ReadLine(); // Чтение строки с клавиатуры
int paramInt = int.Parse(paramString); // Преобразование строки в число
Console.WriteLine("Вы ввели день недели: " + paramInt); // Вывод этого числа
if (paramInt == 1)
{
Console.WriteLine("Понедельник");
}
if (paramInt == 2)
{
Console.WriteLine("Вторник");
}
if (paramInt == 3)
{
Console.WriteLine("Среда");
}
if (paramInt == 4)
{
Console.WriteLine("Четверг");
}
if (paramInt == 5)
{
Console.WriteLine("Пятница");
}
if (paramInt == 6)
{
Console.WriteLine("Суббота");
}
if (paramInt == 7)
{
Console.WriteLine("Воскресенье");
}
if (paramInt > 7)
{
Console.WriteLine("Такого дня недели не бывает");
}
