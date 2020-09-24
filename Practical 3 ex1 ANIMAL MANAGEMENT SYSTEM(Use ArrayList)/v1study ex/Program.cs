using System;

namespace v1study_ex
{
    class Program
    {
       
        static void Main(string[] args)
        {
           BuidAnimal buidAnimal = new BuidAnimal();
           Cat cat = new Cat();
           int c;
            Console.WriteLine("1. Tao con ca sau: ");
            Console.WriteLine("2. Tao con meo: ");
            Console.WriteLine("3. Tao con ca: ");
            Console.WriteLine("4. Xem dong vat tren can: ");
            Console.WriteLine("5. Xem dong vat duoi bien: ");
            Console.WriteLine("6. Xem tat ca dong vat: ");
            Console.WriteLine("7. Xoa dong vat theo id: ");
            Console.WriteLine("7. Exit: ");
                do{
                    Console.WriteLine("Nhap so de chon: ");
                    int.TryParse(Console.ReadLine(),out c);
                    switch (c){
                        case 1:buidAnimal.AddCrocodile();
                        break;
                        case 2:buidAnimal.AddCat();
                        break;
                        case 3:buidAnimal.AddFish();
                        break;
                        case 4:buidAnimal.ViewTerestrialAnimal();
                        break;
                        case 5:buidAnimal.ViewMarineAnimal();
                        break;
                        case 6:buidAnimal.ViewAllAnimal();
                        break;
                        case 7:buidAnimal.DeleteAnimal();
                        break;
                        case 8:return;
                    }
                }while( c!=8);
            }
        }
    }
