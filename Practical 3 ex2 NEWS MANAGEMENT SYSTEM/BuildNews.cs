using System;
using System.Collections;
using System.Collections.Generic;
namespace Practical_3_ex2_NEWS_MANAGEMENT_SYSTEM
{
    public class BuildNews
    {
      
             Hashtable newslist = new Hashtable();
             int d=1;
            
            public void InsertNews(){
                News news = new News();
                news.id=d++;
                Console.WriteLine("Nhap Tieu de: ");
                news.title=Console.ReadLine();
                Console.WriteLine("Nhap Ngay xuat ban: ");
                news.PublishDate=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Tac gia: ");
                news.author=Console.ReadLine();
                Console.WriteLine("Nhap Noi dung: ");
                news.content=Console.ReadLine();
                for(int i=0;i<3;i++){
                    Console.WriteLine("Rate "+(i+1)+":");
                    news[i] = int.Parse(Console.ReadLine());
                }
                newslist.Add(news.id,news);
            }
            public void ViewNews(){
            foreach(News item in newslist.Values){
                    item.Display();
                }
            }   

            public void TbRate()
            {
                if(newslist.Count>0){
                foreach(News item in newslist.Values){
                        item.Calculate();
                        item.Display();
                    }
                }
            }
    }
}
