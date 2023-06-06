
namespace Employee_Mgt_System
{
    partial class frm_Add_New_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Employee));
            this.lbl_Employee_Info = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Designation = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Employee_List = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_UName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Employee_Info
            // 
            this.lbl_Employee_Info.AutoSize = true;
            this.lbl_Employee_Info.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Employee_Info.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Info.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Employee_Info.Location = new System.Drawing.Point(210, 76);
            this.lbl_Employee_Info.Name = "lbl_Employee_Info";
            this.lbl_Employee_Info.Size = new System.Drawing.Size(574, 50);
            this.lbl_Employee_Info.TabIndex = 0;
            this.lbl_Employee_Info.Text = "Add Employee Information";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_ID.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(167, 215);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(57, 40);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Name.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(167, 293);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(108, 40);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_DOB.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(167, 439);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(116, 40);
            this.lbl_DOB.TabIndex = 3;
            this.lbl_DOB.Text = "D.O.B";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.Location = new System.Drawing.Point(167, 363);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(184, 40);
            this.lbl_Mob_No.TabIndex = 4;
            this.lbl_Mob_No.Text = "Mobile No";
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_Designation.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Designation.Location = new System.Drawing.Point(166, 513);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(202, 40);
            this.lbl_Designation.TabIndex = 5;
            this.lbl_Designation.Text = "Designation";
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(528, 206);
            this.tb_ID.MaxLength = 10;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(283, 50);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(528, 360);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(283, 50);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(528, 284);
            this.tb_Name.MaxLength = 120;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(283, 50);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(528, 432);
            this.dtp_DOB.MaxDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1981, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(283, 50);
            this.dtp_DOB.TabIndex = 4;
            this.dtp_DOB.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // cmb_Designation
            // 
            this.cmb_Designation.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Designation.FormattingEnabled = true;
            this.cmb_Designation.Items.AddRange(new object[] {
            "Manager",
            "Developer",
            "Designer",
            "Tester",
            "Cashier",
            "Staff"});
            this.cmb_Designation.Location = new System.Drawing.Point(527, 510);
            this.cmb_Designation.Name = "cmb_Designation";
            this.cmb_Designation.Size = new System.Drawing.Size(283, 48);
            this.cmb_Designation.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Maroon;
            this.btn_Save.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.Khaki;
            this.btn_Save.Location = new System.Drawing.Point(375, 644);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(127, 51);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Purple;
            this.btn_Logout.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Logout.Location = new System.Drawing.Point(860, 6);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(119, 51);
            this.btn_Logout.TabIndex = 7;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Employee_List
            // 
            this.btn_Employee_List.BackColor = System.Drawing.Color.Maroon;
            this.btn_Employee_List.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Employee_List.ForeColor = System.Drawing.Color.Khaki;
            this.btn_Employee_List.Location = new System.Drawing.Point(593, 644);
            this.btn_Employee_List.Name = "btn_Employee_List";
            this.btn_Employee_List.Size = new System.Drawing.Size(264, 51);
            this.btn_Employee_List.TabIndex = 8;
            this.btn_Employee_List.Text = "Employee List";
            this.btn_Employee_List.UseVisualStyleBackColor = false;
            this.btn_Employee_List.Click += new System.EventHandler(this.btn_Employee_List_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Maroon;
            this.btn_Refresh.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.Khaki;
            this.btn_Refresh.Location = new System.Drawing.Point(122, 644);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(159, 51);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.BackColor = System.Drawing.Color.Gray;
            this.lbl_UName.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_UName.Location = new System.Drawing.Point(12, 9);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(188, 38);
            this.lbl_UName.TabIndex = 9;
            this.lbl_UName.Text = "LoggedInUser";
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Employee_List);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Designation);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_Designation);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Employee_Info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee Details";
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Info;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Designation;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Employee_List;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_UName;
    }
}