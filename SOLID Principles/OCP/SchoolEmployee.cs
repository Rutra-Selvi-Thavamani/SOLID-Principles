using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP
{
    class SchoolEmployee
    {
        static void Main(string[] args)
        {
            Employee empRutra = new PermanentEmployee(1, "Rutra");
            Employee empNavya = new TemporaryEmployee(2, "Navya");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}", empRutra.ToString(), empRutra.CalculateBonus(10000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}", empNavya.ToString(), empNavya.CalculateBonus(150000).ToString());
            Console.ReadLine();
        }
    }
    public abstract class Employee   //now  this is open for extension & closed for modification
    {
        public int ID { get; set;  }
        public string Name { get; set; }
        public Employee()
        {
        }
        public Employee(int id, string name)
        {
            this.ID = id; this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()     //using constructors
        { }
        public PermanentEmployee(int id, string name) : base(id, name)   //using constructor with parameters and assigning with the base class
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        { }
        public TemporaryEmployee(int id, string name) 
        { }
        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }
    }

}
