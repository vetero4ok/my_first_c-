using System;
using System.Buffers.Binary;
using System.Security.Cryptography.X509Certificates;




namespace Lists
{
    public class LinkenListMethods
    {

        public static void ToDoLinkTest()
        {

            // Create and initialize a new LinkedList.
            LinkedList<String> ll = new LinkedList<String>();
            ll.AddLast("red");
            ll.AddLast("orange");
            ll.AddLast("yellow");
            ll.AddLast("orange");

            // Display the contents of the LinkedList.
            if (ll.Count > 0)
            {
                Console.WriteLine("The first item in the list is {0}.", ll.First.Value);
                Console.WriteLine("The last item in the list is {0}.", ll.Last.Value);

                Console.WriteLine("The LinkedList contains:");
                foreach (String s in ll)
                    Console.WriteLine("   {0}", s);
            }
            else
            {
                Console.WriteLine("The LinkedList is empty.");
            }
        }


    }

}
