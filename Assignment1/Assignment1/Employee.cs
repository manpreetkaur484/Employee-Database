using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Assignment1
{
   public class Employee
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }

        public Employee(string id, string firstName, string lastName, string address, string email, string phone, string role )
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            Phone = phone;
            Role = role;

        }
        public Employee(){}

         public override string ToString()
         {
             return $"ID:{ID}, FirstName:{FirstName}, LastName:{LastName}, Address:{Address}, Email:{Email}, Phone:{Phone}, Role:{Role}";
         }

        
    }//employee

}//assignment1
