using System;

namespace Practical_4_ex1_STUDENT_MANAGEMENT_SYSTEM
{
    public interface IStudent
    {
         public string fullName{get;set;}
         public int id{get;set;}
         public DateTime DateofBirth{get;set;}
         public string Native {get;set;}
         public string Class{get;set;}
         public string PhoneNo{get;set;}
         public int Mobile{get;set;}

         public void Display(){}
    }
}