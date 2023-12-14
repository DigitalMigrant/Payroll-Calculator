
//
//  Author:  Roselia Dela Cruz
//
//  Purpose:  Assignment 2  ICT 711 - Computer Programming Level 2
//                                
//  Date Created: December 11, 2022
//
//  Description: A custom designed class that will be used to store the information relating to a single employee.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_ICT_711
{

    public class Employee
    {
        //private data
        private string first_name;
        private string last_name;
        private decimal hourly_rate;
        private TimeSheetData logsheet = new TimeSheetData(); //

        //------------------------------------PUBLIC PROPERTIES-----------------------------------------------------//
        public string FirstName
        {
            get => first_name;
            set
            {
                this.first_name = value;
            }
        }

        public string LastName
        {
            get => last_name;
            set
            {
                this.last_name = value;
            }
        }

        public decimal HourlyRate
        {
            get => hourly_rate;
            set
            {
                this.hourly_rate = value;
            }
        }

        //the concatenation of the first and last name
        public string FullName
        {
            get
            {
                string fullname = first_name + " " + last_name;
                return fullname;
            }
        }
        //return the calculated amount of pay for that employee based on the hours worked and the hourly rate.
        public TimeSheetData LogSheet
        {
            get
            {
                return logsheet;
            }
            set
            {
                logsheet.SundayHours = Convert.ToDecimal(value);
                logsheet.MondayHours = Convert.ToDecimal(value);
                logsheet.TuesdayHours = Convert.ToDecimal(value);
                logsheet.WednesdayHours = Convert.ToDecimal(value);
                logsheet.ThursdayHours = Convert.ToDecimal(value);
                logsheet.FridayHours = Convert.ToDecimal(value);
                logsheet.SaturdayHours = Convert.ToDecimal(value);
            }

        }
        //return the calculated amount of pay for that employee based on the hours worked and the hourly rate.
        public decimal PayAmount
        {
            get
            {
                decimal pay;
                if (logsheet.TotalHours < Convert.ToDecimal(37.5))
                {
                    pay = this.CalculatePay(logsheet.TotalHours, Convert.ToDecimal(1.5));
                }
                else 
                {
                    pay = this.CalculatePay(Convert.ToDecimal(37.5), Convert.ToDecimal(1.5));
                }
                return pay;
            }

        }
        //-------------------------------------- PUBLIC METHODS -----------------------------------------------------------//
        //CalculatePay(decimal regularHours, decimal overtimeRate)
        //Calculate the pay using the values passed as the regular hours limit and overtime rate rather than the default values.
        public decimal CalculatePay(decimal regularHours, decimal overtimeRate)
        { 
            decimal gross_pay = (regularHours * hourly_rate) + ((logsheet.TotalHours - regularHours) * (overtimeRate*hourly_rate));
            return gross_pay;
        }

        //ToString() Return the contents of the instance as a string.

        public override string ToString()
        {
            return this.ToString();
        }

        //-------------------------------------- CONSTRUCTORS--------------------------------------------------------------//
        //default constructor that takes no arguments and sets the private data to appropriate values(names to undefined,
        //hourly rate to zero, and hours worked to zero)
        public Employee()
        {
            first_name = "Undefined";
            last_name = "Undefined";
            hourly_rate = 0;
            //because TotalHours is a readonly property, hours work per day will be set individually
            logsheet.SaturdayHours = 0;
            logsheet.MondayHours = 0;
            logsheet.TuesdayHours = 0;
            logsheet.WednesdayHours = 0;
            logsheet.ThursdayHours = 0;
            logsheet.FridayHours = 0;
            logsheet.SaturdayHours = 0;

        }
        //constructor that takes three arguments: the first and last names and the hourly rate.
        public Employee(string fname, string lname, decimal rateperhour)
        {
            first_name = fname;
            last_name = lname;
            hourly_rate = rateperhour;
        }

    }
}
