using System;
namespace v1study_ex
{
    public class Fish:IMarineAnimal
    {
        public Fish()
        {
        }

        public int id { get ; set ; }
        public string name { get ; set ; }
        public int age { get ; set ; }

        public void Move()
        {
            Console.WriteLine("Swim");
        }
        public override string ToString()
        {
    
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            return "";
        }
    }
}