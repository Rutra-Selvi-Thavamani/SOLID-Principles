using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.ISP
{
    interface IStudentDuty
    {
        bool ReadingDuty(string learn);
        bool LearningDuty(string learn);
        bool WritingDuty(string learn);
    }
    interface IStudenthomeDuty
    {
        bool PlayingDuty(string learn);
    }
    interface IStudentSchoolDuty
    {
        bool StudyingDuty(string learn);
    }
    class AllStudentDuties : IStudentDuty, IStudenthomeDuty, IStudentSchoolDuty
    {
        public bool PlayingDuty(string learn)
        {
            Console.WriteLine("Playing duty"); return true;
        }
        public bool WritingDuty(string larn)
        {
            Console.WriteLine("Writing duty"); return true;
        }
        public bool ReadingDuty(string learn)
        {
            Console.WriteLine("reading duty"); return true;
        }
        public bool StudyingDuty(string learn)
        {
            Console.WriteLine("studying duty"); return true;
        }
        public bool LearningDuty(string learn)
        {
            Console.WriteLine("Learning duty"); return true;
        }
    }
    class DuringExams : IStudentDuty   // This class doesn't depend on un-necessary methods
    {
        public bool WritingDuty(string learn)
        {
            Console.WriteLine("learning duty"); return true;
        }
        public bool ReadingDuty(string learn)
        {
            Console.WriteLine("reading duty"); return true;
        }
        public bool LearningDuty(string learn)
        {
            Console.WriteLine("Learning duty"); return true;
        }

    }
}
