namespace Practical_4_ex2_MARKS_MANAGEMENT_SYSTEM
{
    public interface IStudentMark
    {
         string fullname{get;set;}
         int id{get;set;}
         string lop{get;set;}
         int semester{get;set;}
         float AverageMark{get;}
         void DisPlay();

    }
}