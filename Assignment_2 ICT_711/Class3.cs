
//
//  Author:  Roselia Dela Cruz
//
//  Purpose:  Assignment 2  ICT 711 - Computer Programming Level 2
//                                
//  Date Created: December 11, 2022
//
//  Description: A global class that declares all variables and methods to be used in the whole project.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_ICT_711
{
    static class Globals
    {
        // global variables
        public static Boolean add_status;// used to store add record status
        public static List<Employee> employee_record1 = new List<Employee>(); //used to store the employees within the application

        //TurnEmptyToZero()
        //global method to turn empty textbox to zero
        public static decimal TurnEmptyToZero(String text)
        {
            decimal deci_text = 0;
            if (text == "")
                deci_text = 0; 
            else
                try
                {
                    deci_text = Convert.ToDecimal(text);
                }
                catch
                {
                   //Returning zero (0) value for any empty or invalid input.
                }

            return deci_text;
        }
        //TurnZeroToEmpty()
        //global method to turn zero to empty text
        public static string TurnZeroToEmpty(String text)
        {
          string str_text = "";
            if (text == "0")
                str_text = "";
            else
                str_text = text;
            
          return str_text;
        }
    }
}
