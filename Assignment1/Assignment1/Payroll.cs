using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Payroll
    {
      
        public int ID { get; set; }
        public string EmpId { get; set; }
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }
        public string Date { get; set; }

        public Payroll(int id, string employeeId, int hoursWorked, int hourlyRate, string date)
        {
            ID = id;
            EmpId = employeeId;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            Date = date;
        }
        public Payroll() { }


}//Payroll Ending

}//Assignment1 Ending
