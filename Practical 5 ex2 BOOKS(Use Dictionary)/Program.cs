using System;

namespace Practical_5_ex2_BOOKS
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildBook buildBook = new BuildBook();
            int c;
            Console.WriteLine("1. Chen them Book: ");
            Console.WriteLine("2. Xem danh sach Book: ");
            Console.WriteLine("3. Gia trung binh: ");
            Console.WriteLine("4. Exit..: ");
                do{
                    Console.WriteLine("Nhap so de chon: ");
                    int.TryParse(Console.ReadLine(),out c);
                    switch (c){
                        case 1:buildBook.InsertBook();
                        break;
                        case 2:buildBook.ViewBook();
                        break;
                        case 3:buildBook.AveragePrice();
                        break;
                        case 4:return;
                    }
                }while( c!=4);
        }
    }
}
