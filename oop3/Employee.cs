using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    public enum SecurityPrivilege
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class Employee
    {
        // ID, Name, security level, salary, hire date and Gender.
        #region attributes
        private int id;
        private char gender;
        private string name;
        private decimal salary;
        private DateTime hireDate;
        private SecurityPrivilege privilege;

        #endregion
        #region proearities


        public SecurityPrivilege Privilege
        {
            get { return privilege; }
            set { privilege = value; }
        }

        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public char Gender
        {
            get { return gender; }
            set {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    Console.WriteLine ("Gender must be 'M' or 'F'.");
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        #endregion
        // Constructors
        public Employee(int id, string name, SecurityPrivilege privilege, decimal salary, DateTime hireDate, char gender)
        {
            Id = id;
            Name = name;
            Privilege = privilege;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        #region METHODS
        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Gender: {gender}, Salary: {salary:C}, Hire Date: {hireDate.ToShortDateString()}, Privilege: {privilege}";
        }
        #endregion

        #region 
        #endregion
    }
}
