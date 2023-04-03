// See https://aka.ms/new-console-template for more information
Console.Write("Введите значение параметра x: ");
double x = double.Parse(Console.ReadLine());
double result = (Math.Sin(x) - Math.Cos(x)) / 5;

Console.WriteLine($"Результат выполнения функции: {result}");
Console.ReadLine();