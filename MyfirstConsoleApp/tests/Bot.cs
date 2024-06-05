using System;


namespace MyTest;

class Bot : Robot, IRun
{
    public Bot(string name, int size, byte[] cordinates) : base(name, size, cordinates) { }


    public override void Moving(byte speed)
    {
        Console.WriteLine(this.Running(9));
    }
    public string Running(byte speed)
    {
        return "Running with " + speed;
    }


}




