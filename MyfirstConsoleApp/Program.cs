using System;
using System.Buffers.Binary;

// Прості типи:
// byte: 8-бітне ціле число без знака (від 0 до 255)
// sbyte: 8-бітне ціле число зі знаком (від -128 до 127)
// short: 16-бітне ціле число зі знаком (від -32,768 до 32,767)
// ushort: 16-бітне ціле число без знака (від 0 до 65,535)
// int: 32-бітне ціле число зі знаком (від -2,147,483,648 до 2,147,483,647)
// uint: 32-бітне ціле число без знака (від 0 до 4,294,967,295)
// long: 64-бітне ціле число зі знаком (від -9,223,372,036,854,775,808 до 9,223,372,036,854,775,807)
// ulong: 64-бітне ціле число без знака (від 0 до 18,446,744,073,709,551,615)
// float: 32-бітне число з плаваючою комою (від ±1.5e−45 до ±3.4e38, 7 знаків точності)
// double: 64-бітне число з плаваючою комою (від ±5.0e−324 до ±1.7e308, 15-16 знаків точності)
// decimal: 128-бітне число з плаваючою комою для фінансових і грошових обчислень (28-29 знаків точності)
// bool: логічний тип (true або false)
// char: 16-бітний символ Unicode (від '\u0000' до '\uffff')

// Структури (Structs):
// csharp
// Копіювати код
// struct Point
// {
//     public int X;
//     public int Y;
// }
// Перерахування (Enums):
// csharp
// Копіювати код
// enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
// Посилальні типи (Reference Types)
// Посилальні типи зберігають посилання на значення, а не саме значення. Вони включають класи, інтерфейси, масиви і делегати.

// Класи (Classes):
// csharp
// Копіювати код
// class Person
// {
//     public string Name;
//     public int Age;
// }
// Інтерфейси (Interfaces):
// csharp
// Копіювати код
// interface IAnimal
// {
//     void Speak();
// }
// Масиви (Arrays):
// csharp
// Копіювати код
// int[] numbers = { 1, 2, 3, 4, 5 };
// Делегати (Delegates):
// csharp
// Копіювати код
// delegate void Del(string message);
// Типи значення NULL (Nullable Value Types)
// Nullable value types дозволяють значимим типам приймати значення NULL.

// csharp
// Копіювати код
// int? nullableInt = null;
// Кортежі (Tuples)
// Кортежі дозволяють зберігати кілька значень різних типів в одному об'єкті.

// csharp
// Копіювати код
// var person = (Name: "John", Age: 30);
// Console.WriteLine(person.Name); // Виведе: John
// Динамічні типи (Dynamic Types)
// Динамічні типи визначають тип під час виконання.

// csharp
// Копіювати код
// dynamic dyn = 1;
// dyn = "Hello";
// Console.WriteLine(dyn); // Виведе: Hello

class Hello
{

    static void Main()
    {
        // var a = Console.ReadLine();
        // Person person = new Person("Hopper", "Grace");
        // // This line prints "Hello, World" 
        // Console.WriteLine($"Hello, World {a}");
        // Console.WriteLine($"{person.LastName}");

        // Використання nameof для виведення імені властивостей
        // Console.WriteLine($"{nameof(person.LastName)}: {person.LastName}");
        // Console.WriteLine($"{nameof(person.FirstName)}: {person.FirstName}");

        // Console.WriteLine(person.ToString());

        // Person p1 = new Person("Wallace", 75);
        // Person p2 = new Person("", 42);
        // p2.Name = "Wallace";
        // p2.Age = 75;


        // int num = Convert.ToInt32(a);
        // int num_from_parse = int.Parse(a);
        // Console.WriteLine(num);
        // Console.WriteLine(num_from_parse);
        // if (p2.Equals(p1))
        // {
        //     Console.WriteLine("p2 and p1 have the same values.");
        // }
        // else
        // {
        //     Console.WriteLine("p2 and p1 have not the same values.");
        // }

        // byte[] arr = new byte[5];
        // arr[1] = 1;
        Random rand = new Random();
        int [] arr = { 1, 2000000000, 3, 5 };
        foreach (int item in arr)
        {
            short r = Convert.ToInt16(rand.Next(-5, 5));
            short m;
            try
            {
                m = checked((short)item);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occurred during conversion. integar");
                continue;
            }
            short val;
            try
            {
                val = checked((short)(m + r));
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occurred during conversion. val");
                continue;
            }
            Console.WriteLine($"integer - {item}");
            Console.WriteLine($"random short converted - {r}");
            Console.WriteLine($"integer short converted - {item}");
            Console.WriteLine($"summ after converting - {val}");
            Console.WriteLine("_______");
        }
        // Console.WriteLine(arr[2]);

        // string[] arr1 = { "1,2,3,5", "2" };
        // foreach (string item in arr1)
        // {

        //     Console.WriteLine(item);
        // }


    }


}

// public class Person
// {

//     public string LastName;
//     public string FirstName;

//     public Person(string firstName, string lastName)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//     }

//     public override string ToString() => $"{nameof(this.FirstName)}: {this.FirstName},{nameof(this.LastName)}: {this.LastName}";




// }
public struct Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}