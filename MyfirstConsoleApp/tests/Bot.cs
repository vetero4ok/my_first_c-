using System;


namespace MyTest;

class Bot : Robot
{
    public Bot(string name, int size, byte[] cordinates) : base(name, size, cordinates) { }


    public override void Moving(byte speed)
    {
        Console.WriteLine("Bot is jumping " + speed);
    }


}




