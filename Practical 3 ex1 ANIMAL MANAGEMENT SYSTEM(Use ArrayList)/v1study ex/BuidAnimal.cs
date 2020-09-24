using System.Collections.Generic;
using System.Collections;
using System;
using System.Text;
namespace v1study_ex
{
    public class BuidAnimal
    {
         int d=1;
        ArrayList arrayList = new ArrayList();


        public void AddCat(){
            Cat cat =new Cat();
            cat.id=d;
            Console.WriteLine("Nhap ten con meo: ");
            cat.name=Console.ReadLine();
            Console.WriteLine("Nhap tuoi con meo: ");
            cat.age=int.Parse(Console.ReadLine());
            arrayList.Add(cat);
            d++;
        }

        public void AddFish(){
            Fish fish =new Fish();
            fish.id=d;
            Console.WriteLine("Nhap ten con ca: ");
            fish.name=Console.ReadLine();
            Console.WriteLine("Nhap tuoi con ca: ");
            fish.age=int.Parse(Console.ReadLine());
            arrayList.Add(fish);
            d++;
        }
        public void AddCrocodile(){
            Crocodile cro = new Crocodile();
            cro.id=d;
            Console.WriteLine("Nhap ten con ca sau: ");
            cro.name=Console.ReadLine();
            Console.WriteLine("Nhap tuoi con ca sau: ");
            cro.age=int.Parse(Console.ReadLine());
            arrayList.Add(cro);
            d++;
        }
        public void ViewTerestrialAnimal(){
            Cat c = new Cat();
                for(int i=0; i<arrayList.Count;i++)
                if(arrayList[i].GetType().Equals(c.GetType())){

                    arrayList[i].ToString();
                    c.Move();
                }
            }

        public void ViewMarineAnimal(){
            Fish f = new Fish();
            for(int i=0; i<arrayList.Count;i++)
                if(arrayList[i].GetType().Equals(f.GetType())){

                    arrayList[i].ToString();
                    f.Move();
            }
        }

        public void ViewAllAnimal(){
            Console.WriteLine("Hien thi tat ca dong vat: ");
            for(int i=0; i<arrayList.Count;i++)
               arrayList[i].ToString();
        }

        public void DeleteAnimal(){
            int n;
            Console.Write("Please select a key: ");
            int.TryParse(Console.ReadLine(), out n);
            foreach (DictionaryEntry de in arrayList)
            {
                if (de.Key.Equals(n))
                {
                
                arrayList.Remove(n);
                break;
            }
            Console.WriteLine(arrayList.Count);
            }
        }
    }
}



