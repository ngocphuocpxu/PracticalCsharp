using System;
namespace v1study_ex
{
    internal class Crocodile :ITerrestrialAnimal,IMarineAnimal
    {
        public Crocodile()
        {
        }

        public int id { get ; set;}
        public string name { get ; set;}
        public int age { get ; set;}

         void ITerrestrialAnimal.Move(){
            Console.WriteLine("Run");
        }
        
         void IMarineAnimal.Move(){
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