// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число");
int first=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second=int.Parse(Console.ReadLine());
if (first>second)
{
    int q=second*second;
if (first==q) Console.WriteLine($"Число {first} является квадратом {second}");
else Console.WriteLine($"Число {first} НЕ является квадратом {second}");
}
else 
{ int q=first*first;
    if (second==q) Console.WriteLine($"Число {second} является квадратом {first}");
else Console.WriteLine($"Число {second} НЕ является квадратом {first}");
}