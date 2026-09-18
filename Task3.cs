using System;

class Task3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int t = int.Parse(Console.ReadLine());

        int minutes = n * 60 + m + t;
        minutes = minutes % 1440;

        int hours = minutes / 60;
        int min = minutes % 60;

        Console.WriteLine($"{hours:D2}:{min:D2}");
    }
}