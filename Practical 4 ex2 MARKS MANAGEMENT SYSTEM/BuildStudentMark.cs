using System;
using System.Collections;

namespace Practical_4_ex2_MARKS_MANAGEMENT_SYSTEM
{
    public class BuildStudentMark
    {
         Hashtable arrayList = new Hashtable();
             int d=1;
            
            public void InsertStudent(){
                StudentMark studentMark = new StudentMark();
                studentMark.id=d++;
                Console.WriteLine("Nhap fullname: ");
                studentMark.fullname=Console.ReadLine();
                Console.WriteLine("Nhap ten lop hoc: ");
                studentMark.lop=Console.ReadLine();
                Console.WriteLine("Nhap hoc ky hien tai: ");
                studentMark.semester=int.Parse(Console.ReadLine());
                for(int i=0;i<5;i++){
                    Console.WriteLine("Rate "+(i+1)+":");
                    studentMark[i] = int.Parse(Console.ReadLine());
                }
                arrayList.Add(studentMark.id,studentMark);
            }
            public void ViewStudent(){
            foreach(StudentMark item in arrayList.Values){
                    item.DisPlay();
                }
            }
             public void TbRate()
            {
                if(arrayList.Count>0){
                foreach(StudentMark item in arrayList.Values){
                        item.AveCalculate();
                        item.DisPlay();
                    }
                }
            }   
    }
}