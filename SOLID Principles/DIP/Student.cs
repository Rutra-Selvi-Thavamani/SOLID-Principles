using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DIP
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
        public int fee { get; set; }
    }
    public interface IStudentDataAcess
    {
        Student GetStudentDetails(int id);
    }
    public class StudentDataAccess : IStudentDataAcess
    {
        public Student GetStudentDetails(int id)
        {
            Student std = new Student()
            {
                ID = id,
                Name = "Rutra",
                Standard = "10th",
                fee = 100000
            };
            return std;
        }
    }
    public class DataAccessPage
    {
        public static IStudentDataAcess GetstudentDataAccessObj()
        {
            return new StudentDataAccess();
        }
    }
    public class StudentStudyLogicLayer
    {
        IStudentDataAcess _StudentDataAccess;
        public StudentStudyLogicLayer()
        {
            _StudentDataAccess = DataAccessPage.GetstudentDataAccessObj();
        }
        public Student GetStudentDetails(int id)
        {
            return _StudentDataAccess.GetStudentDetails(id);
        }
    }
}
