using System;

namespace ClassTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("hello"));
        }
       


        static string Reverse(string name)
        { 
            string result = "";
            for (int i = name.Length-1; i >= 0; i--)
            {
                result += name[i];
            }
            return result;
        }
    }
}
