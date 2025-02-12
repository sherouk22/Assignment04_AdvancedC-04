using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_AdvancedC_04
{
    public class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }

        private List<Employee> Members = new List<Employee>();

        public void AddMember(Employee employee)
        {
            Members.Add(employee);
            employee.EmployeeLayOff += RemoveMember;
        }

        private void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee employee)
            {
                Members.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from Club {e.Cause}.");
            }


        }
    }
}
