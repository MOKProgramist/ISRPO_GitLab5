// See https://aka.ms/new-console-template for more information
Console.WriteLine("Программа рассчитывает значение введенного числа по формуле: (Sin(число) - Math.Cos(число)) / 5");
Console.Write("Введите значение параметра x: ");
double x;
bool isXDouble = double.TryParse(Console.ReadLine(), out x);
if (!isXDouble)
{
    Console.WriteLine("Введеное значение не является числом.");
    Console.ReadLine();
} 
double result = (Math.Sin(x) - Math.Cos(x)) / 5;

Console.WriteLine($"Результат выполнения функции: {result}");
Console.ReadLine();