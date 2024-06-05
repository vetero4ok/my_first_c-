using System;


namespace MyTest;

class ChildRobot : Robot, IFly
{
    private readonly int damage;
    public int Damage { get; private set; }
    public ChildRobot(string name, int size, byte[] cordinates, int damage) : base(name, size, cordinates)
    {
        this.Damage = damage;
    }

    public override void printValues()
    {
        base.printValues();
        Console.Write("Damage: " + this.Damage + "\n");
    }

    public override void Moving(byte speed)
    {
        Console.WriteLine(this.Flying(5));
    }

    public string Flying(byte speed) 
    {
        return "Flying with " + speed;
    }


}