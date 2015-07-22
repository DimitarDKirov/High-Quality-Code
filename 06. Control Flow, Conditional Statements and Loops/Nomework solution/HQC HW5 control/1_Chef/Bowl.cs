using System;

class Bowl
{
    public Bowl()
    {
    }

    internal void Add(Vegetable vegetable)
    {
        Console.WriteLine(vegetable.ToString() + " is in the bowl");
    }
}

