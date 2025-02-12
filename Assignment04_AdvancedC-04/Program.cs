namespace Assignment04_AdvancedC_04
{
    internal class Program
    { //Assignment03_AdvancedC-03
        static void Main(string[] args)
        {
            Department department = new Department();
            Club club = new Club();
            Employee Employee01 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1990, 5, 5), VacationStock = -1 };
            Employee Employee02 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1850, 11, 22), VacationStock = 5 };
            Employee Employee03 = new Employee { EmployeeID = 3, BirthDate = new DateTime(1880, 1, 2), VacationStock = 5 };

            SalesEmployee salesp = new SalesEmployee { EmployeeID = 10, AchievedTarget = 50 };
            BoardMember bMember = new BoardMember { EmployeeID = 20 };

            department.AddStaff(Employee01);
            department.AddStaff(Employee02);
            club.AddMember(Employee01);
            club.AddMember(Employee02);

            department.AddStaff(salesp);
            department.AddStaff(bMember);
            club.AddMember(salesp);
            club.AddMember(bMember);

            Employee01.EndOfYearOperation();
            Employee02.EndOfYearOperation();
            salesp.CheckTarget(60);
            bMember.Resign();




        }
    }
}
