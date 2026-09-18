using System;

class Task1
{
    static void Main()
    {
        string number = Console.ReadLine();
        int result = 0;

        for (int i = 0; i < number.Length; i++)
        {
            result = result * 2 + (number[i] - '0');
        }

        Console.WriteLine(result);
    }
}