
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
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_ICT_711
{
    public partial class Payroll_Calculator_Form : Form
    {
        string pathString;              //holds the path of currently opened file
        string[] current_filename;      //holds the current file name
        String[] lines;                 //holds data values per line from text file
        String[] value_list_per_line;   //holds data values from a line after removing delimeters
        Boolean edit_status = false;    //holds the status of editing a record
        Boolean a_file_is_opened = false; //use to know if a file is opened or not
        StreamReader emp_file;          // stream reader for opening an emp file
       
        public Payroll_Calculator_Form()
        {
            InitializeComponent();
        }
        //New_File_Click()
        //close any existing employee data, clearing the display area
        //saving any changes if necessary
        private void New_File_Click(object sender, EventArgs e)
        {
            if (edit_status == false)
            {
                Globals.employee_record1.Clear();
                string folderName = @"C:\Employee_Folder";
                pathString = System.IO.Path.Combine(folderName, "Records");
                System.IO.Directory.CreateDirectory(pathString);
                string fileName = "new_file.emp";
                pathString = System.IO.Path.Combine(pathString, fileName);
  
                current_filename = pathString.Split('\\'); // this will be used in Save menu
                currentOpenedFile_label.Text = current_filename[current_filename.Length - 1];

                // Check if file already exists. If yes, delete it.
                if (File.Exists(pathString))
                {
                    File.Delete(pathString);
                }

                // Create a new file     
                using (FileStream new_file = File.Create(pathString))
                {
                   Update_list();
                }
                a_file_is_opened=true;
            }
            else
            {
                var user_answer = MessageBox.Show("Save the changes made to this file?", "Save File",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (user_answer == DialogResult.Yes)
                    saveAs_file_submenu.PerformClick();
                else
                    return;              
            }
         }
        //Open_File_Click()
        //open an existing .emp employee file
        public void Open_File_Click(object sender, EventArgs e)
        {
           if (a_file_is_opened == true)
            { 
              
                Globals.employee_record1.Clear();
            }
            
            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                pathString = dialog.FileName;
                current_filename = pathString.Split('\\'); // this will be used in Save menu and displaying the current file
                currentOpenedFile_label.Text = current_filename[current_filename.Length - 1];

                employee_listBox.Items.Clear();

                using (emp_file = File.OpenText(pathString))
                {
                    string text = emp_file.ReadToEnd();
                    lines = text.Split('\n'); //split the values found per line

                    //for every line, check if empty, check for delimiters then separate the values
                    //before adding to employee record and list box
                    foreach (string line in lines)
                        if (line.Length == 0)
                            continue;
                        else
                        {
                            value_list_per_line = line.Split(new char[] { ',', ' ', '\t', '|' }, 
                                StringSplitOptions.RemoveEmptyEntries);

                            Employee staff = new Employee();
                            staff.FirstName = value_list_per_line[0];
                            staff.LastName = value_list_per_line[1];
                            staff.HourlyRate = Convert.ToDecimal(value_list_per_line[2]);
                            staff.LogSheet.SundayHours = Convert.ToDecimal(value_list_per_line[3]);
                            staff.LogSheet.MondayHours = Convert.ToDecimal(value_list_per_line[4]);
                            staff.LogSheet.TuesdayHours = Convert.ToDecimal(value_list_per_line[5]);
                            staff.LogSheet.WednesdayHours = Convert.ToDecimal(value_list_per_line[6]);
                            staff.LogSheet.ThursdayHours = Convert.ToDecimal(value_list_per_line[7]);
                            staff.LogSheet.FridayHours = Convert.ToDecimal(value_list_per_line[8]);
                            staff.LogSheet.SaturdayHours = Convert.ToDecimal(value_list_per_line[9]);
                            decimal total_WHours = staff.LogSheet.TotalHours;
                            decimal over_time = staff.LogSheet.OvertimeHours;
                            decimal total_pay = staff.PayAmount;
                            Globals.employee_record1.Add(staff);
                            
                        }
                }
                Update_list();
            }
          
            a_file_is_opened = true;
            edit_status = false;
        }
        //SaveFile_Click()
        //save the contents of the application to a file if previously loaded from a file,
        //or prompt the user for a file name to save if the this is new data
        private void SaveFile_Click(object sender, EventArgs e)
        {

            if (a_file_is_opened == true)
            {
                    StreamWriter SaveFile = new StreamWriter(pathString);

                    foreach (Employee emp in Globals.employee_record1)
                    {
                        SaveFile.WriteLine($"{emp.FirstName.Replace(" ", "")} | {emp.LastName.Replace(" ", "")} | {emp.HourlyRate} | {emp.LogSheet.SundayHours} " +
                        $"{emp.LogSheet.MondayHours} {emp.LogSheet.TuesdayHours} {emp.LogSheet.WednesdayHours} " +
                        $"{emp.LogSheet.ThursdayHours} {emp.LogSheet.FridayHours} {emp.LogSheet.SaturdayHours}");
                    }
                    MessageBox.Show("Data saved to " + current_filename[current_filename.Length - 1]);
                    SaveFile.Flush();
                    SaveFile.Close();
            }
            else
            {
                MessageBox.Show("No opened file.");
            }

            edit_status = false;

        }
        //Save_FileAs_Click()
        //prompt the user for a file name and then save the contents of display window
        //to that file
        private void Save_FileAs_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileAsDialog = new SaveFileDialog();
            saveFileAsDialog.Filter = "Emp File|*.emp";
            saveFileAsDialog.Title = "Save as EMP File";
            saveFileAsDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileAsDialog.FileName != "")
            {
                StreamWriter SaveFileAs = new StreamWriter(saveFileAsDialog.FileName);
                foreach (Employee emp in Globals.employee_record1)
                {
                    SaveFileAs.WriteLine($"{emp.FirstName.Replace(" ", "")} | {emp.LastName.Replace(" ", "")} | {emp.HourlyRate} | {emp.LogSheet.SundayHours} " +
                        $"{emp.LogSheet.MondayHours} {emp.LogSheet.TuesdayHours} {emp.LogSheet.WednesdayHours} " +
                        $"{emp.LogSheet.ThursdayHours} {emp.LogSheet.FridayHours} {emp.LogSheet.SaturdayHours}");
                }
                MessageBox.Show("Employee record(s) saved to new file: \n" + saveFileAsDialog.FileName, "Save File As", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                SaveFileAs.Flush();
                SaveFileAs.Close();
                
            }
            edit_status = false;
            return;
        }
        //Close_File_Click()
        //remove any employees from the display area, saving any changes if necessary
        private void Close_File_Click(object sender, EventArgs e)
        {
            if (a_file_is_opened == true)
            {
                if (edit_status == true)
                {
                    //ask to save and call save 
                    DialogResult user_answer = MessageBox.Show("Save changes made to the file?", "Save Changes", 
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (user_answer == DialogResult.Yes)
                        saveAs_file_submenu.PerformClick();
                    else if (user_answer == DialogResult.No)
                    {
                        Globals.employee_record1.Clear();
                        employee_listBox.Items.Clear();
                        currentOpenedFile_label.Text = "No opened file.";
                        a_file_is_opened = false;
                        edit_status = false;
                    }
                    else
                        return;
                }
                else
                {
                    Globals.employee_record1.Clear();
                    employee_listBox.Items.Clear();
                    currentOpenedFile_label.Text = "No opened file.";
                    a_file_is_opened = false;
                }
            }
            
        }
        //Exit_Click()
        //terminate the application, first prompting to save any changes if necessary
        private void Exit_Click(object sender, EventArgs e)
        {
            if (edit_status == true)
            {
                //ask to save and call save 
                DialogResult user_answer = MessageBox.Show("About to exit the program. Save changes made to the file?", "Save Changes",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (user_answer == DialogResult.Yes)
                    saveAs_file_submenu.PerformClick();
                else if (user_answer == DialogResult.Cancel)
                    return;
                else
                    System.Windows.Forms.Application.Exit();
            }

            System.Windows.Forms.Application.Exit();
        }
        //AddNew_Employee_Click()
        // display a modal dialog(shown below) that will let the user add a new employee
        // to the list in the display area
        public void AddNew_Employee_Click(object sender, EventArgs e)
        {
            Globals.add_status = true;
            
            //check first if there is an opened file to work/add on record
            if (a_file_is_opened == true)
            {
                var add_form = new Add_Employee_Form();
                add_form.ShowDialog();
                Update_list();
                edit_status = true;
            }
            else
            {
                MessageBox.Show("No opened file to add record on.");
            }

        }
        //Edit_Employee_Click()
        //display a modal dialog  that will let the user edit the contents of
        //the employee currently selected in the display area list. 
        //If there is no employee selected, a message prompt will inform the user.
        public void Edit_Employee_Click(object sender, EventArgs e)
        {
            Globals.add_status = false;
 
            if (Current_Record() < 0)
                MessageBox.Show("No selected record.");
            else
            {
                var update_form = new Add_Employee_Form();
                update_form.ShowDialog();
                Update_list();
                edit_status = true;
            }
        }
        //Enter_Timesheet_Click()
        //display a modal dialog that will let the user update the hours worked for each day
        //of the week for the employee currently selected in the display area list.
        //If there is no employee selected, a message prompt will inform the user.
        public void Enter_Timesheet_Click(object sender, EventArgs e)
        {
             if (Current_Record() < 0)
                MessageBox.Show("No selected record.");
            else
            {
                var edit_timesheet_form = new Update_Timesheet_Form();
                edit_timesheet_form.ShowDialog();
                edit_timesheet_form.Text = "Update Timesheet Data";
                Update_list();
                edit_status = true;
            }
        }
        //Remove_Employee_Click()
        //remove the currently selected employee from the list after first prompting for confirmation.
        //If there is no employee selected, a message prompt will inform the user.
        public void Remove_Employee_Click(object sender, EventArgs e)
        {
            
            if (Current_Record() < 0)
                MessageBox.Show("No selected record.");
            else
            {
                Globals.employee_record1.RemoveAt(Current_Record());
                Update_list();
                edit_status = true;
            }
        }

        //Current_Record()
        //the method that will get the current set of record in the list box
        //- last index if to add an employee record
        //- selected index if to update or remove an employee record
        public int Current_Record()
        {
            int current_set_of_record;
            if (Globals.add_status == true)
                current_set_of_record = employee_listBox.Items.Count - 1;
            else
                current_set_of_record = employee_listBox.SelectedIndex;
            
            return current_set_of_record;
        }

        //Update_list()
        //the method that will update/print the employee records into the list box
        public void Update_list()
        {
            employee_listBox.Items.Clear();
            foreach (Employee emp in Globals.employee_record1)
            {
                employee_listBox.Items.Add(string.Format("{0, -10} {1, -10}\t {2, 7:$0,0.00} {3, 4} {4, 3} {5, 3} {6, 3} {7, 3} {8, 3} {9, 4}\t{10, 6} {11, 6}\t {12, 10:$0,0.00}",
                emp.FirstName, emp.LastName, emp.HourlyRate, emp.LogSheet.SundayHours, emp.LogSheet.MondayHours,
                emp.LogSheet.TuesdayHours, emp.LogSheet.WednesdayHours, emp.LogSheet.ThursdayHours, emp.LogSheet.FridayHours, emp.LogSheet.SaturdayHours,
                emp.LogSheet.TotalHours, emp.LogSheet.OvertimeHours, emp.PayAmount));
            }
            Current_Record();
        }

    }
}
