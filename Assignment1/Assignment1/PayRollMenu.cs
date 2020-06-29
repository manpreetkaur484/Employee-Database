using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class PayRollMenu
    {

       static List<Payroll> payrolls = new List<Payroll> {
            new Payroll(1, "S3001", 35, 15, "August 15, 2020"),
            new Payroll(2, "S3002", 45, 14, "August 15, 2020"),
            new Payroll(3, "S3003", 20, 14, "January 15, 2020"),
            new Payroll(4, "S3004", 38, 16, "March 15, 2020"),
            new Payroll(5, "S3005", 25, 20, "October 15, 2020"),
            new Payroll(6, "S3006", 18, 22, "Febuary 15, 2020"),
        };//PaYroll menu
        


        public static void DisplayPayRollMenu()
        {
            MainMenu obj1 = new MainMenu();
            Console.WriteLine("******You Are at PayRoll Menu*******");
            Console.WriteLine("Press 1 to insert new payroll entry");
            Console.WriteLine("Press 2 view payroll history for an employee");
            Console.WriteLine("Press 3 to Update Payroll");
            Console.WriteLine("Press 4 to Delete Payroll");
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
                        Program.AddPayrollEntry();
                                     DisplayPayRollMenu();
                                     break;
                                 case 2:
                        Program.ViewAllPayrolls();
                                     DisplayPayRollMenu();
                                     break;

                                 case 3:
                        Program.UpdatePayroll();
                        Program.ViewAllPayrolls();
                                     DisplayPayRollMenu();
                                     break;
                                 case 4:
                        Program.DeletePayroll();
                        Program.ViewAllPayrolls();
                                     DisplayPayRollMenu();
                                     break;
                                 case 5:
                                     MainMenu obj = new MainMenu();
                                     obj.DisplayMainMenu();
                                     break;

                             }//Switch
                  }//if
             else
             {
                 Console.WriteLine("Inavlid Input!\n\n");
                 DisplayPayRollMenu();
             }
                        
        }//DisplayPayRollMenu

        
       

    }//PayRollMenu

}//Assignment 1
