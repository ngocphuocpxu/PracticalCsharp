using System;
using System.Collections;
using System.Collections.Generic;

namespace Practical_5_ex2_BOOKS
{
    public class BuildBook
    {
         Dictionary<int, object> ListBook = new Dictionary<int, object>();
             int d=1;
            
            public void InsertBook(){
                Book book = new Book();
                book.id=d++;
                Console.WriteLine("Nhap name: ");
                book.name=Console.ReadLine();
                Console.WriteLine("Nhap ngay xuat ban: ");
                book.PublishDate=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten tac gia: ");
                book.author=Console.ReadLine();
                Console.WriteLine("Nhap language: ");
                book.language=Console.ReadLine();
                for(int i=0;i<5;i++){
                    Console.WriteLine("Rate "+(i+1)+":");
                    book[i] = int.Parse(Console.ReadLine());
                }
                ListBook.Add(book.id,book);
            }
            public void ViewBook(){
            foreach(Book item in ListBook.Values){
                    item.Display();
                }
            }
             public void AveragePrice()
            {
              foreach (Book item in ListBook.Values)
            {
                item.AvePrice();
                item.Display();
                }
            }   
    }
}