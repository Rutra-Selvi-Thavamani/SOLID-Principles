using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.SRP
{
    interface ISchool   //interface school having its own responsibility
    {
        bool Admissions(string stdname, string standardstudying);
        bool FeeForStudent(string stdname, string standardstuding, int fee);
    }
    interface ITeacher     //interface teacher having its own responsibility
    {
        void TeachingToStudents(string teaching );
    }
    interface IStudent     //interfacestudent having its own responsibility
    {
        void Learning(string learning);
        void WritingExams(string exams);
    }
}
