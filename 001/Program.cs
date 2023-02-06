// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число дня недели");
int day=int.Parse(Console.ReadLine());
day=day-1;
string[] week = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
if (day<5) Console.WriteLine($"{week[day]} - не выходной день");
else Console.WriteLine($"{week[day]} - выходной день");