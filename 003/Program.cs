// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти");
int chet=int.Parse(Console.ReadLine());
if (chet==1) Console.WriteLine("Координаты х и y могут быть больше нуля");
else 
{
    if (chet==2) Console.WriteLine("Координаты х может быть меньше нуля. Координата у может быть больше нуля");
    else 
    {
        if (chet==3) Console.WriteLine ("Координаты х и у могут быть меньше нуля");
        else 
        {
            if (chet==4) Console.WriteLine($"Координаты х может быть больше нуля. Координата у может быть меньше нуля");
            else Console.WriteLine("Введите корректное число от 1 до 4");
        }
    }
}