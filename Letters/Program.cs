using System;

class ArrayExample
{
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";

        foreach (char letter in letters)
        {
            if (letter != ' ')
            {
                name += letter;
            }
        }

        for (int i = 1; i <= 10; i++)
        {
            SendMessage(name, i);
        }

        Console.ReadKey();
    }

    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}
