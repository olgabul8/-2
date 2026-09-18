using System;

class Task2
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        string result = "";

        if (number == 0)
        {
            Console.WriteLine("0");
            return;
        }

        while (number > 0)
        {
            int remainder = number % 2;
            result = remainder.ToString() + result;
            number = number / 2;
        }

        Console.WriteLine(result);
    }
}