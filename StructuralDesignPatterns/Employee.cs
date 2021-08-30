using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern1
{
    public class Employee
    {
        public int id;
        public string name;
        public string designation;
        public decimal salary;

        public Employee(int ID, string Name, string Designation, decimal Salary)
        {
            this.id = ID;
            this.name = Name;
            this.designation = Designation;
            this.salary = Salary;
        }
    }
}
