using System;

namespace Practical_3_ex2_NEWS_MANAGEMENT_SYSTEM
{
    public interface INews
    {
         int id{get;set;}
         string title{get;set;}
         DateTime PublishDate{get;set;}
         string author{get;set;}
         string content{get;set;}
         float average{get;}
         void Display();
    }
}