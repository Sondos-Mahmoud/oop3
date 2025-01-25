namespace oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create employees
            HiringDate dbaHireDate = new HiringDate(10, 5, 2023);
            HiringDate guestHireDate = new HiringDate(15, 7, 2022);
            HiringDate securityOfficerHireDate = new HiringDate(1, 1, 2021);


            Employee[] empArr = new Employee[3];
            empArr[0] = new Employee(001, "John Doe", SecurityPrivilege.DBA, 70000, dbaHireDate, 'M');
            empArr[1] = new Employee(002, "Jane Smith", SecurityPrivilege.Guest, 50000, guestHireDate, 'F');
            empArr[2] = new Employee(003, "Mike Johnson", SecurityPrivilege.Secretary, 60000, securityOfficerHireDate, 'M');

            // Sorting employees based on hire date
            Array.Sort(empArr, (emp1, emp2) => emp1.HireDate.Year.CompareTo(emp2.HireDate.Year));

            // Printing sorted array
            Console.WriteLine("Employees sorted by hire date:");
            foreach (var emp in empArr)
            {
                Console.WriteLine(emp.ToString());
            }
        }

    }
    }
