using System;

namespace _Class_Obj_
{
    class Program
    {
        static void Main(string[] args)
        {
            Form user = new Form("Aytac", "Veyisli", "1234567890", "Programming", "nthng");
            user.GetInfo();
            
        }
    }
    class Form
    {
        public string Name;
        public string Surname;
        public string Phone;
        public string Lessons;
        public string Note;


        public Form()
        {

        }

      
        public Form(string name, string surname, string phone, string lessons, string note)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Lessons = lessons;
            Note = note;

        }
        public  void GetInfo()
        {
            Console.WriteLine( $"{Name} {Surname} {Phone} {Lessons} {Note} ");
        }

        

        
    }
}
