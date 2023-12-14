namespace Assignment_2_ICT_711
{
    partial class Payroll_Calculator_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.new_file_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.open_file_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.save_file_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs_file_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.close_file_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_file_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.employee_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNew_emp_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_emp_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.enterTimesheet_emp_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.remove_emp_submenu = new System.Windows.Forms.ToolStripMenuItem();
            this.employee_listBox = new System.Windows.Forms.ListBox();
            this.currentOpenedFile_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu,
            this.employee_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_file_submenu,
            this.open_file_submenu,
            this.save_file_submenu,
            this.saveAs_file_submenu,
            this.close_file_submenu,
            this.exit_file_submenu});
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(46, 24);
            this.file_menu.Text = "File";
            // 
            // new_file_submenu
            // 
            this.new_file_submenu.Name = "new_file_submenu";
            this.new_file_submenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.new_file_submenu.Size = new System.Drawing.Size(233, 26);
            this.new_file_submenu.Text = "New";
            this.new_file_submenu.Click += new System.EventHandler(this.New_File_Click);
            // 
            // open_file_submenu
            // 
            this.open_file_submenu.Name = "open_file_submenu";
            this.open_file_submenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open_file_submenu.Size = new System.Drawing.Size(233, 26);
            this.open_file_submenu.Text = "Open";
            this.open_file_submenu.Click += new System.EventHandler(this.Open_File_Click);
            // 
            // save_file_submenu
            // 
            this.save_file_submenu.Name = "save_file_submenu";
            this.save_file_submenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save_file_submenu.Size = new System.Drawing.Size(233, 26);
            this.save_file_submenu.Text = "Save";
            this.save_file_submenu.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // saveAs_file_submenu
            // 
            this.saveAs_file_submenu.Name = "saveAs_file_submenu";
            this.saveAs_file_submenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAs_file_submenu.Size = new System.Drawing.Size(233, 26);
            this.saveAs_file_submenu.Text = "Save As";
            this.saveAs_file_submenu.Click += new System.EventHandler(this.Save_FileAs_Click);
            // 
            // close_file_submenu
            // 
            this.close_file_submenu.Name = "close_file_submenu";
            this.close_file_submenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.close_file_submenu.Size = new System.Drawing.Size(233, 26);
            this.close_file_submenu.Text = "Close";
            this.close_file_submenu.Click += new System.EventHandler(this.Close_File_Click);
            // 
            // exit_file_submenu
            // 
            this.exit_file_submenu.Name = "exit_file_submenu";
            this.exit_file_submenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exit_file_submenu.Size = new System.Drawing.Size(233, 26);
            this.exit_file_submenu.Text = "Exit";
            this.exit_file_submenu.Click += new System.EventHandler(this.Exit_Click);
            // 
            // employee_menu
            // 
            this.employee_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNew_emp_submenu,
            this.edit_emp_submenu,
            this.enterTimesheet_emp_submenu,
            this.remove_emp_submenu});
            this.employee_menu.Name = "employee_menu";
            this.employee_menu.Size = new System.Drawing.Size(89, 24);
            this.employee_menu.Text = "Employee";
            // 
            // addNew_emp_submenu
            // 
            this.addNew_emp_submenu.Name = "addNew_emp_submenu";
            this.addNew_emp_submenu.Size = new System.Drawing.Size(234, 26);
            this.addNew_emp_submenu.Text = "Add New Employee";
            this.addNew_emp_submenu.Click += new System.EventHandler(this.AddNew_Employee_Click);
            // 
            // edit_emp_submenu
            // 
            this.edit_emp_submenu.Name = "edit_emp_submenu";
            this.edit_emp_submenu.Size = new System.Drawing.Size(234, 26);
            this.edit_emp_submenu.Text = "Edit Employee";
            this.edit_emp_submenu.Click += new System.EventHandler(this.Edit_Employee_Click);
            // 
            // enterTimesheet_emp_submenu
            // 
            this.enterTimesheet_emp_submenu.Name = "enterTimesheet_emp_submenu";
            this.enterTimesheet_emp_submenu.Size = new System.Drawing.Size(234, 26);
            this.enterTimesheet_emp_submenu.Text = "Enter Timesheet Data";
            this.enterTimesheet_emp_submenu.Click += new System.EventHandler(this.Enter_Timesheet_Click);
            // 
            // remove_emp_submenu
            // 
            this.remove_emp_submenu.Name = "remove_emp_submenu";
            this.remove_emp_submenu.Size = new System.Drawing.Size(234, 26);
            this.remove_emp_submenu.Text = "Remove Employee";
            this.remove_emp_submenu.Click += new System.EventHandler(this.Remove_Employee_Click);
            // 
            // employee_listBox
            // 
            this.employee_listBox.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_listBox.FormattingEnabled = true;
            this.employee_listBox.ItemHeight = 20;
            this.employee_listBox.Location = new System.Drawing.Point(0, 50);
            this.employee_listBox.MultiColumn = true;
            this.employee_listBox.Name = "employee_listBox";
            this.employee_listBox.Size = new System.Drawing.Size(1040, 404);
            this.employee_listBox.TabIndex = 1;
            // 
            // currentOpenedFile_label
            // 
            this.currentOpenedFile_label.AutoSize = true;
            this.currentOpenedFile_label.Location = new System.Drawing.Point(816, 12);
            this.currentOpenedFile_label.Name = "currentOpenedFile_label";
            this.currentOpenedFile_label.Size = new System.Drawing.Size(95, 16);
            this.currentOpenedFile_label.TabIndex = 2;
            this.currentOpenedFile_label.Text = "No opened file";
            // 
            // Payroll_Calculator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.currentOpenedFile_label);
            this.Controls.Add(this.employee_listBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Payroll_Calculator_Form";
            this.Text = "Employee Payroll Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_menu;
        private System.Windows.Forms.ToolStripMenuItem new_file_submenu;
        private System.Windows.Forms.ToolStripMenuItem open_file_submenu;
        private System.Windows.Forms.ToolStripMenuItem save_file_submenu;
        private System.Windows.Forms.ToolStripMenuItem saveAs_file_submenu;
        private System.Windows.Forms.ToolStripMenuItem close_file_submenu;
        private System.Windows.Forms.ToolStripMenuItem exit_file_submenu;
        private System.Windows.Forms.ToolStripMenuItem employee_menu;
        private System.Windows.Forms.ToolStripMenuItem addNew_emp_submenu;
        private System.Windows.Forms.ToolStripMenuItem edit_emp_submenu;
        private System.Windows.Forms.ToolStripMenuItem enterTimesheet_emp_submenu;
        private System.Windows.Forms.ToolStripMenuItem remove_emp_submenu;
        private System.Windows.Forms.ListBox employee_listBox;
        private System.Windows.Forms.Label currentOpenedFile_label;
    }
}

