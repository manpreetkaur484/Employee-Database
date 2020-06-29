using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class EmployeeMenu
    {
        public static void DisplayEmployeeMenu()
        {
            MainMenu obj1 = new MainMenu();
            Console.WriteLine("\n***You Are at Employee Menu***\n");
            Console.WriteLine("Press 1 to list all employees");
            Console.WriteLine("Press 2 to add a new employee");
            Console.WriteLine("Press 3 to update an employee");
            Console.WriteLine("Press 4 to delete an employee");
            Console.WriteLine("Press 5 to return to the main menu");

            Console.WriteLine("");
            Console.WriteLine("Enter your choice:");


            Console.WriteLine("");
            int option = Program.GetUserChoice(5);

            if (option == 1 || option == 2 || option == 3 || option == 4 || option == 5)
            {

                switch (option)

            {
                case 1:
                    Program.DisplayAllEmployees();
                    DisplayEmployeeMenu();
                    break;
                case 2:
                        Program.AddNewEmployee();
                        Program.DisplayAllEmployees();
                    DisplayEmployeeMenu();
                    break;
                case 3:
                        Program.UpdateEmployee();
                        Program.DisplayAllEmployees();
                    DisplayEmployeeMenu();
                    break;
                case 4:
                        Program.DeleteEmployee();
                        Program.DisplayAllEmployees();
                    DisplayEmployeeMenu();
                    break;
                case 5:
                    obj1.DisplayMainMenu();
                    break;
               
            }//Switch
            }//if
            else
            {
                Console.WriteLine("Inavlid Input!\n\n");
                DisplayEmployeeMenu();
            }//else
        }

    }//DisplayEmployeeMenu Closing
}

