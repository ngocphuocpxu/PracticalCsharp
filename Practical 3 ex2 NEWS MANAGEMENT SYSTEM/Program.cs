using System;

namespace Practical_3_ex2_NEWS_MANAGEMENT_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildNews buildNews = new BuildNews();
            int c;
            Console.WriteLine("1. Chen News moi: ");
            Console.WriteLine("2. Xem danh sach News: ");
            Console.WriteLine("3. Ty le trung binh: ");
            Console.WriteLine("4. Exit..: ");
                do{
                    Console.WriteLine("Nhap so de chon: ");
                    int.TryParse(Console.ReadLine(),out c);
                    switch (c){
                        case 1:buildNews.InsertNews();
                        break;
                        case 2:buildNews.ViewNews();
                        break;
                        case 3:buildNews.TbRate();
                        break;
                        case 4:return;
                    }
                }while( c!=4);
            }
        }
    }

