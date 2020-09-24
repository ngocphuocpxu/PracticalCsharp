using System;

namespace Practical_4_ex1_STUDENT_MANAGEMENT_SYSTEM
{

    class Program
    {
        static void Main(string[] args)
        {
            BuildStudent buildStudent = new BuildStudent();
            Student student = new Student();
            int c;
            Console.WriteLine("1. Chen sinh vien moi: ");
            Console.WriteLine("2. Xem danh sach sinh vien: ");
            Console.WriteLine("3. Tim kiem sinh vien: ");
            Console.WriteLine("4. Exit..: ");
                do{
                    Console.WriteLine("Nhap so de chon: ");
                    int.TryParse(Console.ReadLine(),out c);
                    switch (c){
                        case 1:buildStudent.AddStudent();
                        break;
                        case 2:buildStudent.ViewStudent();
                        break;
                        case 3:buildStudent.SearchStudent();
                        break;
                        case 4:return;
                    }
                }while( c!=4);
            }
        }
    }

