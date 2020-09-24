using System;
namespace Practical_4_ex2_MARKS_MANAGEMENT_SYSTEM
{
    public class StudentMark : IStudentMark
    {
        public StudentMark(string fullname, int id, string lop, int semester, float averageMark)
        {
            this.fullname = fullname;
            this.id = id;
            this.lop = lop;
            this.semester = semester;
            this.AverageMark = averageMark;

        }

        public StudentMark()
        {
        }

        public string fullname { get; set; }
        public int id { get; set; }
        public string lop { get; set; }
        public int semester { get; set; }
        public float AverageMark { get; }

        public void DisPlay()
        {
            System.Console.WriteLine("ID: "+id+ " FullName: "+ fullname+ " Lop: "+lop+ 
            " Semester: "+semester+ " AverageMark: "+average);
        }

         int[] SubjectMarkList = new int[5];
        public int this[int index]
        {
            get{
                return SubjectMarkList[index];
            }
            set{
               SubjectMarkList[index]=value;
            }
        }
        float average;
        public void AveCalculate(){
            average=(float) (SubjectMarkList[0]+SubjectMarkList[1]+SubjectMarkList[2]+
            SubjectMarkList[3]+SubjectMarkList[4])/5;
        }
    }
}