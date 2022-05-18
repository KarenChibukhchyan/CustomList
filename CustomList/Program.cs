using System;

namespace CustomList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Insert(2, 44);
            Console.WriteLine(list);
        }
    }

}