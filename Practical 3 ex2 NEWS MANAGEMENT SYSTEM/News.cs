using System;

namespace Practical_3_ex2_NEWS_MANAGEMENT_SYSTEM
{
    public class News : INews
    {
        public News(int id, string title, DateTime publishDate, string author, string content, float average)
        {
            this.id = id;
            this.title = title;
            this.PublishDate = publishDate;
            this.author = author;
            this.content = content;
            this.average = average;

        }

        public News()
        {
        }

        public int id { get; set; }
        public string title { get; set; }
        public DateTime PublishDate { get; set; }
        public string author { get; set; }
        public string content { get; set; }
        
        public float Average{get;}

        float INews.average => throw new NotImplementedException();

        public void Display()
        {
            Console.WriteLine("Title: " + title + " PublishDate: " + PublishDate +
            " Author: " + author + "Content: " + content + " Average: " + average);
        }

        int[] RateList = new int[3];
        public int this[int index]
        {
            get{
                return RateList[index];
            }
            set{
                RateList[index]=value;
            }
        }
        float average;
        public void Calculate(){
            average=(float) (RateList[0]+RateList[1]+RateList[2])/3;
        }
    }
}