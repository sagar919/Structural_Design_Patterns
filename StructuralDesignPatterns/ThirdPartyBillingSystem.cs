using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern1
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach(Employee employee in listEmployee)
            {
                Console.WriteLine("Rs " + employee.salary + "Salary credited to" + employee.name);
            }

        }
    }
}
