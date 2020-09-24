using System;
using System.Collections;

namespace Practical_4_ex1_STUDENT_MANAGEMENT_SYSTEM
{
    public class BuildStudent
    {
        int d=1;
         Hashtable arrayList = new Hashtable();
         public void AddStudent(){
            Student stu =new Student();
            stu.id=d;
            Console.WriteLine("Nhap ten hoc sinh: ");
            stu.fullName=Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            stu.DateofBirth=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Native: ");
            stu.Native=Console.ReadLine();
             Console.WriteLine("Nhap Class: ");
             stu.Class=Console.ReadLine();
              Console.WriteLine("Nhap PhoneNo: ");
            stu.PhoneNo=Console.ReadLine();
             Console.WriteLine("Nhap Mobile: ");
            stu.Mobile=int.Parse(Console.ReadLine());
            arrayList.Add(d,stu);
            d++;
        }
        public void ViewStudent(){
            foreach(Student item in arrayList.Values){
                item.Display();
            } 
        }

        public void SearchStudent(){
             Console.WriteLine("Nhap ten sv: ");
                string name =Console.ReadLine();
            foreach(Student item in arrayList.Values){   
                if(item.fullName.Equals(name)){
                    item.Display();
                }
                
            }
        }
    }
}


