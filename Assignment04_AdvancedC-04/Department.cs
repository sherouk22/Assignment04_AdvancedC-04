using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_AdvancedC_04
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        private List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee employee)
        {
            Staff.Add(employee);
            employee.EmployeeLayOff += RemoveStaff;
        }

        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee employee)
            {
                Staff.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed due to {e.Cause}");
            }
        }



    }
}
