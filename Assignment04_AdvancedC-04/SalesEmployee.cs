using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_AdvancedC_04
{
    public class SalesEmployee : Employee
    {
        public int AchievedTarget { get; set; }

        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.SalesTargetNotMet });
                return false;
            }
            return true;
        }
    }
}
