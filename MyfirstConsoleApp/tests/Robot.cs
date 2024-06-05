using System;


namespace MyTest;

class Robot
{
    private string name;
    private int size;
    private byte[] cordinates;


    public Robot(string name, int size, byte[] cordinates)
    {
        this.name = name;
        this.size = size;
        this.cordinates = cordinates;
    }

    public string Name
    {

        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 50)
            {
                throw new ArgumentException("Name cannot be empty or longer than 50 characters.");
            }

            name = value;
        }
    }
    public int Size
    {
        get
        {
            return this.size;
        }
        set
        {
            this.size = value;
        }
    }
    public byte[] Cordinates
    {
        get
        {
            return cordinates ?? new byte[] { 0, 0 };

        }
        set { }
    }


}