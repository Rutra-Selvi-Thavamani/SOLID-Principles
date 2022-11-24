using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.LSP
{
    public abstract class Student
    {
        abstract public void SetLearning(string best, string worst);
    }
    public class StudentsWhoCanStudy : Student
    {
        public override void SetLearning(string best, string worst)
        {
            Console.WriteLine("students who can study");
        }
        public virtual void StudyLevel()
        {
            Console.WriteLine("I am studing day and night");
        }
    }
    public class StudentsWhoCannotStudy : Student
    {
        public override void SetLearning(string best, string worst)
        {
            Console.WriteLine("students who cannot study");
        }
    }
}
