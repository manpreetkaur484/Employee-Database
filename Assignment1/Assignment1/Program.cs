using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome, Please choose a command:\n");
            MainMenu obj = new MainMenu();
            obj.DisplayMainMenu();
            // MainMenu.DisplayMainMenu();
        }//Main method closing


        public static int GetUserChoice(int choiceMax)
        {
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice < 1 || choice > choiceMax)
            {
                // Console.WriteLine();
                Console.WriteLine("Please try again");
                // break;
            }
            return choice;
        }//GetUserChoice Closing


        static List<Employee> Employees = new List<Employee> {

            new Employee("S3001", "Manpreet","Kaur",    "45 Trevino Cresent Brampton",    "manpreet@gmail.com", "6476066266","Sales"),
            new Employee("S3002", "Jason",    "Bond",   "55 Don Minaker Mississauga",     "jason@gmail.com",    "9056066266", "Cashier"),
            new Employee("S3003", "Ashley",   "Sandhu", "60 Park Flower Ave Malton",      "ashley@gmail.com",   "6476666266", "Manager"),
            new Employee("S3004", "James",    "Grewal", "71 Goodwill Cresent Woodbridge", "james@gmail.com",    "4166066266", "Cashier"),
            new Employee("S3005", "Wendy",    "Browns", "37 Whitehouse Circle Brampton",  "wendy@gmail.com",    "6475555556", "Cashier"),
            new Employee("S3006", "Sukhdeep",  "Singh", "88 Guru Street Mississauga",     "sukhdeep@gmail.com", "6444444446", "Sales")

        };//employee List

        static List<Payroll> Payrolls = new List<Payroll> {

            new Payroll(1, "S3001", 35, 15, "December 21, 2020"),
            new Payroll(2, "S3002", 45, 14, "August 15, 2020"),
            new Payroll(3, "S3003", 20, 14, "January 15, 2020"),
            new Payroll(4, "S3004", 38, 16, "March 15, 2020"),
            new Payroll(5, "S3005", 25, 20, "October 15, 2020"),
            new Payroll(6, "S3006", 18, 22, "Febuary 15, 2020")

        };//Payroll List

        static List<Vacation> Vacations = new List<Vacation> {

          new Vacation(1, "S3001", 20),
          new Vacation(2, "S3002", 30),
          new Vacation(3, "S3003", 15),
          new Vacation(4, "S3004", 18),
          new Vacation(5, "S3005", 18),
          new Vacation(6, "S3006", 15)

        };//Vacations List








        //ALL THE METHODS FOR EMPLOYEES THAT DISPLAY, INSERT, UPDATE, AND DELETE DATA
        public static void DisplayAllEmployees()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------LIST OF ALL THE EMPLOYEES---------------------------------------------\n");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------\n");
            var allEmployees = from emp in Employees
                               select emp;

            foreach (var item in allEmployees)
            {
                Console.WriteLine($"{item.ID,-10} {item.FirstName,-10} {item.LastName,-10} {item.Address,-35} {item.Email,-20} {item.Phone,-15} {item.Role}");
            }
            Console.WriteLine("\n");

        }//displayAllEmployees Closing



        public static void AddNewEmployee()
        {
            int ID;
            int vacations = 14;
            int vid = 1;
            try
            {
               

                Console.WriteLine("Enter the Following asked information to add the employee!");

                Console.WriteLine("\nEnter the Employee Id:");
                string id = Console.ReadLine();
                if (string.IsNullOrEmpty(id))
                {
                    Console.WriteLine("Please enter correct id again");
                    id = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the First Name of the Employee:");
                string fName = Console.ReadLine();
                if (string.IsNullOrEmpty(fName))
                {
                    Console.WriteLine("Please enter correct name again");
                    fName = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the Last Name of the Employee:");
                string lName = Console.ReadLine();
                if (string.IsNullOrEmpty(lName))
                {
                    Console.WriteLine("Please enter correct name again");
                    lName = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the Address of the employee:");
                string add = Console.ReadLine();
                if (string.IsNullOrEmpty(add))
                {
                    Console.WriteLine("Please enter correct address again");
                    add = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the Email Address of employee:");
                string email = Console.ReadLine();
                
                if (string.IsNullOrEmpty(email))
                {
                    Console.WriteLine("Please enter correct email address again");
                    email = Console.ReadLine();
                }


                Console.WriteLine("\nEnter the Phone Number of the employee:");
                string pNum = Console.ReadLine();
                if (string.IsNullOrEmpty(pNum))
                {
                    Console.WriteLine("Please enter correct Phone Number again");
                    pNum = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the role of the employee:");
                string rol = Console.ReadLine();
                if (string.IsNullOrEmpty(rol))
                {
                    Console.WriteLine("Please enter correct Role again");
                    rol = Console.ReadLine();
                }

                // Employee Employee = new Employee(id, fName, lName, add, email, pNum, rol);
                Employees.Add(new Employee(id, fName, lName, add, email, pNum, rol));

                //adding the vacation days for employees
                
                Vacations.Add(new Vacation(vid, id, vacations));
                vid++;

                Console.WriteLine("Employee added Successfully!\n");


            }
            catch (Exception)
            {
                Console.WriteLine("Error! Try Again!\n");
                // Int32 option1 = Program.DisplayMainMenu();
                //Program.MainCall(option1);
            }

        }//addNewEmployee Closing

        public static void UpdateEmployee()
        {
            Console.WriteLine("Enter the EMPLOYEE ID for the employee you want to Update. Example S3001");
            string id = Console.ReadLine();
            Employee employee = Employees.FirstOrDefault(v => v.ID == id);
            if (employee == null)
            {
                Console.WriteLine("Employee with given ID is not found!\n");
                return;
            }
            else
            {
                Console.WriteLine($"Selected Employee:\n\n{employee}");

                Console.WriteLine("\nEnter new ID for employee");
                string empId = Console.ReadLine();
                if (string.IsNullOrEmpty(empId))
                {
                    Console.WriteLine("Please enter correct employee ID again");
                    empId = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the First Name of employee");
                string empFname = Console.ReadLine();
                if (string.IsNullOrEmpty(empFname))
                {
                    Console.WriteLine("Please enter correct First name again");
                    empFname = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the Last Name of employye");
                string empLname = Console.ReadLine();
                if (string.IsNullOrEmpty(empLname))
                {
                    Console.WriteLine("Please enter correct Last name again");
                    empLname = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the Address of the employee:");
                string empadd = Console.ReadLine();
                if (string.IsNullOrEmpty(empadd))
                {
                    Console.WriteLine("Please enter correct address name again");
                    empadd = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the Email Address of employee:");
                string empemail = Console.ReadLine();
                if (string.IsNullOrEmpty(empemail))
                {
                    Console.WriteLine("Please enter correct email address again");
                    empemail = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the Phone Number of the employee:");
                string emppNum = Console.ReadLine();
                if (string.IsNullOrEmpty(emppNum))
                {
                    Console.WriteLine("Please enter correct Phone Number again");
                    emppNum = Console.ReadLine();
                }

                Console.WriteLine("\nEnter the role of the employee:");
                string emprol = Console.ReadLine();
                if (string.IsNullOrEmpty(emprol))
                {
                    Console.WriteLine("Please enter correct Role again");
                    emprol = Console.ReadLine();
                }

                employee.ID = empId;
                employee.FirstName = empFname;
                employee.LastName = empLname;
                employee.Address = empadd;
                employee.Email = empemail;
                employee.Phone = emppNum;
                employee.Role = emprol;

                Console.WriteLine("Employee has been updated successfully! Here is the list for your reference!\n");
            }//ELSE
        }//updateEmployee Closing

        public static void DeleteEmployee()
        {
            Console.WriteLine("Enter the EMPLOYEE ID for the employee you want to delete. Example S3001");
            string id = Console.ReadLine();
            Employee employee = Employees.FirstOrDefault(v => v.ID == id);
            if (employee == null)
            {
                Console.WriteLine("Employee with given ID is not found!\n");
                return;
            }
            else
            {
                Employees.RemoveAll(r => r.ID == id);
                Console.WriteLine("Employee has been delete successfully!\n");
            }
        }//deleteEmployee Closing


        //ALL THE METHODS FOR EMPLOYEES THAT DISPLAY, INSERT, UPDATE, AND DELETE DATA ENDS









        public static void AddPayrollEntry()
        {

            Console.WriteLine("Enter Payroll ID as 1 , 2 or 3 etc");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Employee ID");
            string employeeID = Console.ReadLine();
            bool alreadyExists = Employees.Any(em => em.ID == employeeID);
            if (alreadyExists == true)
            {
                Console.WriteLine("\nEnter Hours Worked");
                int hoursworked = Int32.Parse(Console.ReadLine());
               

                Console.WriteLine("\nEnter Hourly Rate");
                int hourlyrate = Int32.Parse(Console.ReadLine());
                

                Console.WriteLine("\nEnter Date as \"'September 23, 2020'");
                string dates = Console.ReadLine();
                if (string.IsNullOrEmpty(dates))
                {
                    Console.WriteLine("\nPlease enter correct Date again");
                    dates = Console.ReadLine();
                }

                Payrolls.Add(new Payroll(id, employeeID, hoursworked, hourlyrate, dates));
                /*Vacation Updates*/
                var vs = from Vacation v in Vacations select v;
                foreach (Vacation v in vs)
                {
                    if (v.EmployeeID == employeeID)
                    {
                        v.NumberOfDays++;

                    }//if ends
                }//foreach
                Console.WriteLine("Payroll has been added Successfully!\n");
            }//if
            else
            {
                Console.WriteLine("Employee Does not exist with this Id.\n");
            }

    }//AddPayrollEntry method


    public static void ViewAllPayrolls()
    {
            var payrolls = from Payroll p in Payrolls select p;
            Console.WriteLine("ID\t\tEmployee Id\tHours Worked\tHourlyRate\t\tDate");
            foreach (Payroll p in payrolls)
            {
                Console.WriteLine(p.ID + "\t\t" + p.EmpId + "\t\t" + p.HoursWorked + "\t\t" + p.HourlyRate + "\t\t" + p.Date);
            }
            Console.WriteLine("");
        }//ViewAllPayrolls method


    public static void UpdatePayroll()
    {
            Console.WriteLine("Enter the EMPLOYEE ID for the employee WHOSE PAYROLL YOU WANT TO UPDATE. Example S3001");
            string id = Console.ReadLine();
            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("\nPlease enter correct ID again");
                id = Console.ReadLine();
            }

            Payroll payroll = Payrolls.FirstOrDefault(v => v.EmpId == id);
            if (payroll == null)
            {
                Console.WriteLine("Employee with given ID is not found!\n");
                return;
            }
            else
            {
                Console.WriteLine("\nEnter Hours Worked");
                int hoursworked = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter Hourly Rate");
                int hourlyrate = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter Date as \"'September 23, 2020'");
                string dates = Console.ReadLine();
                if (string.IsNullOrEmpty(dates))
                {
                    Console.WriteLine("Please enter correct ID again\n");
                    dates = Console.ReadLine();
                }

                payroll.HoursWorked = hoursworked;
                payroll.HourlyRate = hourlyrate;
                payroll.Date = dates;

            }


            }//UpdatePayroll method


    public static void DeletePayroll()
    {
            Console.WriteLine("Enter the EMPLOYEE ID for the employee WHOSE PAYROLL YOU WANT TO DELETE. Example S3001\n");
            string id = Console.ReadLine();
            Employee employee = Employees.FirstOrDefault(v => v.ID == id);
            if (employee == null)
            {
                Console.WriteLine("Employee with given ID is not found!\n");
                return;
            }
            else
            {
                Payrolls.RemoveAll(r => r.EmpId == id);
                Console.WriteLine("Employee has been delete successfully!\n");
            }
        }//DeletePayroll methods








    public static void DisplayVacaitosData()
    {
            var vacations = from Vacation v in Vacations select v;
            Console.WriteLine("ID\t\tEmployee Id\t\tVacations");
            foreach (Vacation vd in vacations)
            {
                Console.WriteLine(vd.ID + "\t\t\t" + vd.EmployeeID + "\t\t" + vd.NumberOfDays);
            }
            Console.WriteLine("");

     }//dispplay vacation method

    public static void AddVacations()
    {
            Console.WriteLine("\nEnter vacation ID as 1 , 2 etc:");
            int ID = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Employee ID like 'S3001'");
            string id = Console.ReadLine();
            if (string.IsNullOrEmpty(id))
            {
                Console.WriteLine("Please enter correct ID again");
                id = Console.ReadLine();
            }

            Console.WriteLine("Enter the number of vacation days");
            int days = Int32.Parse(Console.ReadLine());

            Vacation vacation = Vacations.FirstOrDefault(v => v.EmployeeID == id);
            if (vacation == null)
            {
                Console.WriteLine("Employee with given ID is not found!\n");
                return;
            }
            else
            {
               
                Vacations.Add(new Vacation(ID, id, days));
                Console.WriteLine("Vacation days has been added into exiting vacation days\n");
            }
        }//AddVacations method

        public static void UpdateVacations()
    {
            Console.WriteLine("Enter the EMPLOYEE ID for the employee WHOSE VACATIONS YOU WANT TO UPDATE. Example S3001");
            string id = Console.ReadLine();
            Vacation vacation = Vacations.FirstOrDefault(v => v.EmployeeID == id);
            if (vacation == null)
            {
                Console.WriteLine("Employee with given ID is not found!\n");
                return;
            }
            else
            {
                Console.WriteLine($"Selected Vacation:\n\n{vacation}");
                Console.WriteLine("Enter vacation ID");
                int vacId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number of vacation days");
                int vacDays = Int32.Parse(Console.ReadLine());


                vacation.ID = vacId;
                vacation.NumberOfDays = vacDays;

            }

        }//UpdateVacations method


        public static void DeleteVacations()
    {
            Console.WriteLine("Enter the vacation ID YOU WANT TO DELETE LIKE 1 , 2, OR 3");
            int id = Int32.Parse(Console.ReadLine());
            Vacation vacation = Vacations.FirstOrDefault(v => v.ID == id);
            if (vacation == null)
            {
                Console.WriteLine("Vacation ID does not exit!\n");
                return;
            }
            else
            {
                Vacations.RemoveAll(r => r.ID == id);
                Console.WriteLine("Vacation data has been delete successfully!\n");
            }
        }//DeleteVacations methods


}//Program Closing

}//Assignment1 Closing