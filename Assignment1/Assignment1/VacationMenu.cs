using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class VacationMenu
    {

        public static void DisplayVacationMenu()
        {
            MainMenu obj1 = new MainMenu();
            Console.WriteLine("*****You Are at Vacations Menu******");
            Console.WriteLine("Press 1 to view vacation days");
            Console.WriteLine("Press 2 add vacation days");
            Console.WriteLine("Press 3 to Update vacation days");
            Console.WriteLine("Press 4 to Delete vacations");
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
                        Program.DisplayVacaitosData();
                                     DisplayVacationMenu();
                                     break;
                                 case 2:
                        Program.AddVacations();
                        Program.DisplayVacaitosData();
                        DisplayVacationMenu();
                                     break;

                                 case 3:
                        Program.UpdateVacations();
                        Program.DisplayVacaitosData();
                                     DisplayVacationMenu();
                                     break;
                                 case 4:
                        Program.DeleteVacations();
                        Program.DisplayVacaitosData();
                                     DisplayVacationMenu();
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
                DisplayVacationMenu();
             }
                                      
        }//DisPlay Vacation Menu

    }//VacationMenu

}//Assignment1
