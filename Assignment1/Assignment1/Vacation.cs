using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Vacation
    {
        public int ID { get; set; }
        public string EmployeeID { get; set; }
        public int NumberOfDays { get; set; }
        

        public Vacation(int id, string employeeID, int numberOfDays)
        {
            ID = id;
            EmployeeID = employeeID;
            NumberOfDays = numberOfDays;
        }
    }
}
