using System;

namespace DS.LESSON_1.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Display the pattern like pyramid using the alphabet.";
            string[] list = str.Split(" ");
            int a = list.Length - 1;
            while (a != -1)
            {
                Console.WriteLine(list[a]);
                a--;
            }
        }
    }
}
