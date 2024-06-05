using System;
using System.Buffers.Binary;
using System.IO;

namespace MyTest
{
    class Hello
    {

        static void Main()
        {
            // DoConvertsTest();
            // DoStringTests();
            // ReadAndWrite();
            DoWithClass();






        }
        public static void DoWithClass()
        {
            Robot bot = new Robot("bot", 65, new byte[] { 0, 0 });
            bot.Name = "Ivan";
            Console.WriteLine(bot.Size);
            bot.Size = 55;
            // Console.WriteLine(bot.Size);
            ChildRobot child = new ChildRobot("bot", 65, new byte[] { 1, 0 }, 6666);
            // Console.WriteLine(bot.Name);
            // Console.WriteLine(child.Damage);
            bot.printValues();
            child.printValues();

            // Console.WriteLine(ArrayToString(new List<object>() { bot.Cordinates }));
            // Console.WriteLine(ArrayToString(new List<object>() { child.Cordinates }));

        }

        public static void DoConvertsTest()
        {
            Random rand = new Random();
            int[] arr = { 1, 2000000000, 3, 5 };
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
        }

        public static void DoStringTests()
        {
            // var a = Console.ReadLine();
            // Person person = new Person("Hopper", 12);
            // // This line prints "Hello, World" 
            // Console.WriteLine($"Hello, World {a}");
            // Console.WriteLine($"{person.LastName}");

            // // Використання nameof для виведення імені властивостей
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

            string word = "h,e,l,l,o,!";
            Console.WriteLine(word);
            word = String.Concat(word, "?");
            Console.WriteLine(word);
            Console.WriteLine(String.Compare(word, "llo"));
            // return  0 =  complete match, -1 less text, 1 more text
            string[] letters = word.Split(' ', ',');
            Console.WriteLine("______");
            Console.WriteLine(ArrayToString(new List<object>(letters)));

        }

        public static void ReadAndWrite()
        {
            // Console.WriteLine("Enter text");
            // string input = Console.ReadLine();
            // using (FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate))
            // {
            //     byte[] TextOnByte = System.Text.Encoding.Default.GetBytes(input);
            //     stream.Write(TextOnByte);
            // }



            using (FileStream stream = File.OpenRead("info.txt"))
            {
                byte[] written = new byte[stream.Length];
                stream.Read(written);
                string textFromFile = System.Text.Encoding.Default.GetString(written);
                Console.WriteLine(textFromFile);
            }

        }

        public static string ArrayToString(List<object> arg)
        {
            return String.Join("", arg.Select(value => value.ToString()).ToArray());
        }


    }

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
}
