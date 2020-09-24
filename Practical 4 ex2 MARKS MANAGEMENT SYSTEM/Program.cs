using System;

namespace Practical_4_ex2_MARKS_MANAGEMENT_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildStudentMark buildStudentMark = new BuildStudentMark();
            int c;
            Console.WriteLine("1. Chen student moi: ");
            Console.WriteLine("2. Xem danh sach Student: ");
            Console.WriteLine("3. Ty le trung binh: ");
            Console.WriteLine("4. Exit..: ");
                do{
                    Console.WriteLine("Nhap so de chon: ");
                    int.TryParse(Console.ReadLine(),out c);
                    switch (c){
                        case 1:buildStudentMark.InsertStudent();
                        break;
                        case 2:buildStudentMark.ViewStudent();
                        break;
                        case 3:buildStudentMark.TbRate();
                        break;
                        case 4:return;
                    }
                }while( c!=4);
        }
    }
}

