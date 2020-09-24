using System;
namespace Practical_5_ex2_BOOKS
{
     public interface IBook
    {
         int id{get;set;}
         string name{get;set;}
         DateTime PublishDate{get;set;}
         string author{get;set;}
         string language{get;set;}
         float AveragePrice{get;}

         void Display();
    }
}