using System;

public class speshal
{
    public speshal()
    {

    public string name;
    public int salary { get; set; }
    public string otdel { get; set; }
    public void info()
    {
        Console.WriteLine($"Специалистът {name}, със заплата {salary} от отдел {otdel}.");
    }

    }
}
