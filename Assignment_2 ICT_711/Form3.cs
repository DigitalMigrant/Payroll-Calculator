
//
//  Author:  Roselia Dela Cruz
//
//  Purpose:  Assignment 2  ICT 711 - Computer Programming Level 2
//                                
//  Date Created: December 11, 2022
//
//  Description:  A program written to demonstrate the the following:
//  
//      •Creating and using classes
//      •Combining classes using composition
//      •Using a List collection
//      •Building a more sophisticated application that includes a main menu, context menu, modal dialogs and a Listbox control

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_ICT_711
{
    //A partial class that will be used to update the timesheet of selected employee record
    public partial class Update_Timesheet_Form : Form
    {
        int record_number;  //holds the index of selected record in the list box
        public Update_Timesheet_Form()
        {
            InitializeComponent();
        }
        //Update_Timesheet_Form_Load()
        //this will load an Update form for the selected timesheet and pulls out the values from employee record list
        private void Update_Timesheet_Form_Load(object sender, EventArgs e)
        {
            //get the selected index record,
            record_number = ((Payroll_Calculator_Form)Payroll_Calculator_Form.ActiveForm).Current_Record();

            if (record_number < 0)
            {
                MessageBox.Show("No selected employee to update.");
                this.Close();
            }
            else
            {
                //display the record of hours worked = 0, no dispplay in textbox
                sun_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.SundayHours));
                mon_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.MondayHours));
                tue_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.TuesdayHours));
                wed_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.WednesdayHours));
                thu_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.ThursdayHours));
                fri_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.FridayHours));
                sat_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.SaturdayHours));

            }
        }
        //Update_button_Click()
        //get the values from textboxes, empty values should be converted to zero
        //replace the selected employee's timesheet and update list in the listbox
        public void Update_button_Click(object sender, EventArgs e)
        {

            string fname = Globals.employee_record1.ElementAt(record_number).FirstName;
            string lname = Globals.employee_record1.ElementAt(record_number).LastName;
            decimal rate_per_hour = Globals.employee_record1.ElementAt(record_number).HourlyRate;

            Employee staff = new Employee(fname, lname, rate_per_hour);
            Globals.employee_record1.RemoveAt(record_number);  
            staff.LogSheet.SundayHours = Convert.ToDecimal(Globals.TurnEmptyToZero(sun_textBox.Text));
            staff.LogSheet.MondayHours = Convert.ToDecimal(Globals.TurnEmptyToZero(mon_textBox.Text));
            staff.LogSheet.TuesdayHours = Convert.ToDecimal(Globals.TurnEmptyToZero(tue_textBox.Text));
            staff.LogSheet.WednesdayHours = Convert.ToDecimal(Globals.TurnEmptyToZero(wed_textBox.Text));
            staff.LogSheet.ThursdayHours = Convert.ToDecimal(Globals.TurnEmptyToZero(thu_textBox.Text));
            staff.LogSheet.FridayHours = Convert.ToDecimal(Globals.TurnEmptyToZero(fri_textBox.Text));
            staff.LogSheet.SaturdayHours = Convert.ToDecimal(Globals.TurnEmptyToZero(sat_textBox.Text));
            decimal total_wHours = staff.LogSheet.TotalHours;
            decimal overtime = staff.LogSheet.OvertimeHours;
            decimal pay_amount = staff.PayAmount;
            Globals.employee_record1.Insert(record_number, staff);
 
            this.Close();

        }
        //Cancel_button_Click()
        //discard the edited timesheet
        public void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
