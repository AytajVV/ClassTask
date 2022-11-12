using System;
using System.Text;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString("lorem ipsum");
        }


        static void ReverseString(string name)
        {
         
            StringBuilder strngbldr = new StringBuilder();
            
            for (int i = name.Length-1; i >= 0; i--)
            {
                strngbldr.Append(name[i]);
                
            }
            string result = strngbldr.ToString();
            string[] array = result.Split(" ");
            for (int i = array.Length-1; i >=0; i--)
            {
                Console.WriteLine(array[i]);
                //for (int j = array.Length-1; j >= 0; j--)
                //{
                //    Console.WriteLine(array[j]);
                //}
                //Console.WriteLine(array[i]);
                //string s1 = string.Join(" ", array[i]);
                //Console.WriteLine(s1);
            }
            string s1 = string.Join(" ", array);
            Console.WriteLine(s1);

        }
    }
}
