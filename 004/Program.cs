// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Сколько координат у вашего отрезка?");
int k=int.Parse(Console.ReadLine());
if (k==2) 
{
    Console.WriteLine("Введите координату х первой точки");
    int x1=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату y первой точки");
    int y1=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату х второй точки");
    int x2=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату y второй точки");
    int y2=int.Parse(Console.ReadLine());
    double sqrt=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
    Console.WriteLine($"Расстояние между точками равно {sqrt}");
    }
else 
{ 
    if (k==3)
{
    Console.WriteLine("Введите координату х первой точки");
    int x1=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату y первой точки");
    int y1=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату z первой точки");
    int z1=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату х второй точки");
    int x2=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату y второй точки");
    int y2=int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координату z второй точки");
    int z2=int.Parse(Console.ReadLine());
    double sqrt=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    Console.WriteLine($"Расстояние между точками равно {sqrt}");
}
    else Console.WriteLine("Условие не подходит");
} 
