
//
//  Author:  Roselia Dela Cruz
//
//  Purpose:  Assignment 2  ICT 711 - Computer Programming Level 2
//                                
//  Date Created: December 11, 2022
//
//  Description: A custom designed class that will be used to store hours worked for each employee data.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_ICT_711
{
    public class TimeSheetData
    {

        private decimal [] hours_perday = new decimal [7];  // decimal array to store the hours for each day
        private decimal _total_hours;                       // store the total number of hours from Sunday to Saturday
        private decimal _overtime_hours;                    // will store the number of overtime hours 



        //------------------------------------PUBLIC PROPERTIES-----------------------------------------------------//
        public decimal [] Hours_Worked
        { get 
            { 
                return hours_perday; 
            } 
            set 
            { 
                hours_perday = value; 
            } 
        }

        //SundayHours a read/write property to get/set the hours worked for Sunday
        public decimal SundayHours 
        {
            get => hours_perday[0];
            set
            {
                //_sunday_hours = value; OMIT
                hours_perday[0] = value;
            }
        }
        //MondayHours a read/write property to get/set the hours worked for Monday
        public decimal MondayHours
        {
            get => hours_perday[1];
            set
            {
                //_sunday_hours = value; OMIT
                hours_perday[1] = value;
            }
        }
        //TuesdayHours a read/write property to get/set the hours worked for Tuesday
        public decimal TuesdayHours
        {
            get => hours_perday[2];
            set
            {
                //_sunday_hours = value; OMIT
                hours_perday[2] = value;
            }
        }

        //WednesdayHours a read/write property to get/set the hours worked for Wednesday
        public decimal WednesdayHours
        {
            get => hours_perday[3];
            set
            {
                //_sunday_hours = value; OMIT
                hours_perday[3] = value;
            }
        }

        //ThursdayHours a read/write property to get/set the hours worked for Thursday
        public decimal ThursdayHours
        {
            get => hours_perday[4];
            set
            {
                //_sunday_hours = value; OMIT
                hours_perday[4] = value;
            }
        }

        //FridayHours a read/write property to get/set the hours worked for Friday
        public decimal FridayHours
        {
            get => hours_perday[5];
            set
            {
                //_sunday_hours = value; OMIT
                hours_perday[5] = value;
            }
        }

        //SaturdayHours a read/write property to get/set the hours worked for Saturday
        public decimal SaturdayHours
        {
            get => hours_perday[6];
            set
            {
                //_sunday_hours = value; OMIT
                hours_perday[6] = value;
            }
        }

        //TotalHours a readonly property the gives the total hours worked for the week
        public decimal TotalHours
        {
            get
            {
                _total_hours = hours_perday[0] + hours_perday[1] + hours_perday[2] + hours_perday[3] + hours_perday[4] + hours_perday[5] + hours_perday[6];
                return _total_hours;
            }
            
        }

        //OvertimeHours a readonly property that give the overtime hours for that week if any,
        //otherwise has a value of zero.
        public decimal OvertimeHours
        {
            get
            {
                _overtime_hours = TotalHours - Convert.ToDecimal(37.5);
                if (_overtime_hours <= 0)
                    return 0;
                else
                    return _overtime_hours;
          
            }
        }

        //-------------------------------------- CONSTRUCTORS--------------------------------------------------------------//
        //A default constructor that takes no arguments and sets the hours worked for each day of the week to zero
        public TimeSheetData()
        {
            hours_perday[0] = 0;
            hours_perday[1] = 0;
            hours_perday[2] = 0;
            hours_perday[3] = 0;
            hours_perday[4] = 0;
            hours_perday[5] = 0;
            hours_perday[6] = 0;
            _total_hours = 0;
            _overtime_hours = 0;
        }

        //A constructor that takes 5 decimal arguments that sets the hours worked for Saturday and Sunday to zero, and the hours worked from Monday to Friday to the values passed as arguments in that order
        public TimeSheetData( decimal mon_hours, decimal tue_hours, decimal wed_hours, decimal thu_hours, decimal fri_hours)
        {
            //SHALL I PUT INSIDE THE ARRAY
            hours_perday[0] = 0;
            hours_perday[1] = mon_hours;
            hours_perday[2] = tue_hours;
            hours_perday[3] = wed_hours;
            hours_perday[4] = thu_hours;
            hours_perday[5] = fri_hours;
            hours_perday[6] = 0;
            _total_hours = 0;
            _overtime_hours = 0;

        }
        //A constructor that takes 7 decimal arguments that sets the hours worked for each day of the week from Sunday to Saturday to the values passed as arguments in that order

        public TimeSheetData(decimal sun_hours, decimal mon_hours, decimal tue_hours, decimal wed_hours, decimal thu_hours, decimal fri_hours, decimal sat_hours)
        {
            hours_perday[0] = sun_hours;
            hours_perday[1] = mon_hours;
            hours_perday[2] = tue_hours;
            hours_perday[3] = wed_hours;
            hours_perday[4] = thu_hours;
            hours_perday[5] = fri_hours;
            hours_perday[6] = sat_hours;
            _total_hours = 0;
            _overtime_hours = 0;
        }
        //A constructor that takes 1 argument, a seven element decimal array containing the hours worked for seven days,
        //starting at Sunday and sets the value of hours worked to those in the corresponding positions of the argument array.
        public TimeSheetData(decimal [] hours_each_day)
        {
            hours_perday[0] = hours_each_day[0];
            hours_perday[1] = hours_each_day[1];
            hours_perday[2] = hours_each_day[2];
            hours_perday[3] = hours_each_day[3];
            hours_perday[4] = hours_each_day[4];
            hours_perday[5] = hours_each_day[5];
            hours_perday[6] = hours_each_day[6];
            _total_hours = 0;
            _overtime_hours = 0;
        }
        //-------------------------------------- PUBLIC METHODS -----------------------------------------------------------//
        //ToString() Return the contents of the instance as a string.
        public override string ToString()
        {
            return this.ToString();
        }
    }
}
