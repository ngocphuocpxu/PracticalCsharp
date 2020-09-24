using System;

namespace Practical_5_ex2_BOOKS
{
    public class Book : IBook
    {
        public int id {get;set;}
        public string name {get;set;}
        public DateTime PublishDate {get;set;}
        public string author {get;set;}
        public string language {get;set;}

        public float AveragePrice {get;}

        float average;
        public void Display()
        {
           System.Console.WriteLine("Name: "+name+" PublishDate: "+PublishDate+ " Author: "+author
           +" Language: "+ "AveragePrice: "+average);
        }
        
        int [] PriceList = new int[5];
         public int this[int index]
        {
            get{
                return PriceList[index];
            }
            set{
               PriceList[index]=value;
            }
        }
        public void AvePrice(){
            average=(float) (PriceList[0]+PriceList[1]+PriceList[2]+
            PriceList[3]+PriceList[4])/5;
        }
    }
}