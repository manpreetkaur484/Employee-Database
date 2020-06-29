using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class MainMenu
    {
        public  void DisplayMainMenu()
        {
            Console.WriteLine("******You Are at Main Menu*******");
            Console.WriteLine("Press 1 to modify employees");
            Console.WriteLine("Press 2 to add payroll");
            Console.WriteLine("Press 3 to view vacatioin days");
            Console.WriteLine("Press 4 to exit program");
        
           
            Console.WriteLine("");
            Console.WriteLine("Enter your choice:");

            int option = Program.GetUserChoice(4);

            if (option == 1 || option == 2 || option == 3 || option == 4)
            {
                switch (option)
                {
                    case 1:
                        EmployeeMenu.DisplayEmployeeMenu();
                        Console.WriteLine("Enter your choice!");
                        break;
                    case 2:
                        
                        PayRollMenu.DisplayPayRollMenu();
                        Console.WriteLine("Enter your choice!");
                        break;
                    case 3:
                       
                        VacationMenu.DisplayVacationMenu();
                        Console.WriteLine("Enter your choice!");
                        break;
                    case 4:
                        Console.WriteLine("Thank you! See you next Time!");
                        break;

                }//Switch
            }//if

            else
            {
                Console.WriteLine("Inavlid Input!\n\n");
                DisplayMainMenu();
            }
         
        }//DisplayMainMenu Closing 
    }
}
