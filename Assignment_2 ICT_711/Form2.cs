
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
    //A partial class that will be used to add a new or update an existing employee record
    public partial class Add_Employee_Form : Form
    {
        int record_number;
     
        public Add_Employee_Form()
        {
            InitializeComponent();
         
        }
        //Add_Employee_Form_Load()
        //this will load an Add or Update form and pulls out the values from employee record list
        public void Add_Employee_Form_Load(object sender, EventArgs e)

        {
            record_number = ((Payroll_Calculator_Form)Payroll_Calculator_Form.ActiveForm).Current_Record();
           
            if (Globals.add_status == false)
            {
                this.Text = "Update Employee";
                this.add_button.Text = "Update";

                if (record_number < 0)
                {
                    MessageBox.Show("No selected employee to update.");
                    this.Close();
                }
                else
                {
                    fname_textbox.Text = Globals.employee_record1.ElementAt(record_number).FirstName;
                    lname_textbox.Text = Globals.employee_record1.ElementAt(record_number).LastName;
                    hrate_textbox.Text = Convert.ToString(Globals.employee_record1.ElementAt(record_number).HourlyRate);

                    sun_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.SundayHours));
                    mon_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.MondayHours));
                    tue_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.TuesdayHours));
                    wed_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.WednesdayHours));
                    thu_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.ThursdayHours));
                    fri_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.FridayHours));
                    sat_textBox.Text = Globals.TurnZeroToEmpty(Convert.ToString(Globals.employee_record1.ElementAt(record_number).LogSheet.SaturdayHours));
                   
                }
            }
        }
        //Add_button_Click()
        //get the last index or selected index from listbox
        //get the values from textboxes, names/rate cannot be empty, when empty, hours = 0
        //update the employee record
        public void Add_button_Click(object sender, EventArgs e)
        {
            if(Globals.add_status == true)
            {
                Employee staff = new Employee();

                if (fname_textbox.Text == "" || lname_textbox.Text == "" || hrate_textbox.Text == "")
                {
                    MessageBox.Show("First name, Last name or hourly rate cannot be empty.", "Empty Field Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    staff.FirstName = fname_textbox.Text;
                    staff.LastName = lname_textbox.Text;
                    try
                    { staff.HourlyRate = Convert.ToDecimal(hrate_textbox.Text); }
                    catch
                    {
                        MessageBox.Show("Invalid input in hourly rate. Please enter a valid number.");
                        hrate_textbox.Focus();
                        return;
                    }

                }
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
                Globals.employee_record1.Add(staff);
          
            }
            else
            {
                Globals.employee_record1.RemoveAt(record_number); 
                
                Employee staff = new Employee();

                if (fname_textbox.Text == "" || lname_textbox.Text == "" || hrate_textbox.Text == "")
                {
                    MessageBox.Show("First name, Last name or hourly rate cannot be empty.", "Empty Field Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    staff.FirstName = fname_textbox.Text;
                    staff.LastName = lname_textbox.Text;
                    try
                    { staff.HourlyRate = Convert.ToDecimal(hrate_textbox.Text); }
                    catch
                    { 
                        MessageBox.Show("Invalid input in hourly rate. Please enter a valid number.", "Invalid Input", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        hrate_textbox.Focus();
                        return;
                    }

                }

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
            }
            this.Close();

        }
        //Cancel_button_Click()
        //discard the added or updated employee record
        public void Cancel_button_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
