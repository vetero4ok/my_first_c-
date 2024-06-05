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
        Console.WriteLine("\nDamage: "+ this.Damage);
    }


}