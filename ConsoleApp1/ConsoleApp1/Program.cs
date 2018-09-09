using System;

class BC
{
    public virtual void Display()
    {
        System.Console.WriteLine("BC::Display");
    }
}

class DC : BC
{
     new public void Display()
    {
        System.Console.WriteLine("DC::Display");
    }
}

class TC : DC
{
    new public void Display()
    {
        System.Console.WriteLine("TC::Display");
    }
}

class Demo
{
    public static void Main()
    {
        DC b = new TC();
        b.Display();
        b.Display(); b.Display(); b.Display();
        Console.ReadLine();

    }
}