using System;


namespace MyTest;

class ChildRobot : Robot
{
    private readonly int damage;
    public int Damage { get ; private set; }
    public ChildRobot(string name, int size, byte[] cordinates, int damage) : base(name, size, cordinates)
    {
        this.Damage = damage;
    }

    public override void printValues()
    {
        base.printValues();
        Console.Write("Damage: "+ this.Damage + "\n");
    }

    public override void Moving(byte speed)
    {
        Console.WriteLine("Child is moving " + speed);
    }


}