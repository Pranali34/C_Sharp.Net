
namespace Employee_Mgt_System
{
    partial class frm_View_Employee_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Employee_List));
            this.lbl_Employee_Details = new System.Windows.Forms.Label();
            this.dgv_Employee_List = new System.Windows.Forms.DataGridView();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Mgt_SystemDataSet3 = new Employee_Mgt_System.Employee_Mgt_SystemDataSet3();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Mgt_SystemDataSet1 = new Employee_Mgt_System.Employee_Mgt_SystemDataSet1();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Add_Employee = new System.Windows.Forms.Button();
            this.employee_Mgt_SystemDataSet = new Employee_Mgt_System.Employee_Mgt_SystemDataSet();
            this.employeeMgtSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_DetailsTableAdapter = new Employee_Mgt_System.Employee_Mgt_SystemDataSet1TableAdapters.Employee_DetailsTableAdapter();
            this.lbl_UName = new System.Windows.Forms.Label();
            this.employee_DetailsTableAdapter1 = new Employee_Mgt_System.Employee_Mgt_SystemDataSet3TableAdapters.Employee_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Mgt_SystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Mgt_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Mgt_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeMgtSystemDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details
            // 
            this.lbl_Employee_Details.AutoSize = true;
            this.lbl_Employee_Details.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Employee_Details.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Employee_Details.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Employee_Details.Location = new System.Drawing.Point(241, 49);
            this.lbl_Employee_Details.Name = "lbl_Employee_Details";
            this.lbl_Employee_Details.Size = new System.Drawing.Size(469, 50);
            this.lbl_Employee_Details.TabIndex = 1;
            this.lbl_Employee_Details.Text = "Employee Details List";
            // 
            // dgv_Employee_List
            // 
            this.dgv_Employee_List.AllowUserToAddRows = false;
            this.dgv_Employee_List.AllowUserToDeleteRows = false;
            this.dgv_Employee_List.AutoGenerateColumns = false;
            this.dgv_Employee_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee_List.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dgv_Employee_List.DataSource = this.employeeDetailsBindingSource1;
            this.dgv_Employee_List.Location = new System.Drawing.Point(60, 135);
            this.dgv_Employee_List.Name = "dgv_Employee_List";
            this.dgv_Employee_List.ReadOnly = true;
            this.dgv_Employee_List.RowHeadersWidth = 51;
            this.dgv_Employee_List.RowTemplate.Height = 24;
            this.dgv_Employee_List.Size = new System.Drawing.Size(865, 483);
            this.dgv_Employee_List.TabIndex = 2;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDetailsBindingSource1
            // 
            this.employeeDetailsBindingSource1.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource1.DataSource = this.employee_Mgt_SystemDataSet3;
            // 
            // employee_Mgt_SystemDataSet3
            // 
            this.employee_Mgt_SystemDataSet3.DataSetName = "Employee_Mgt_SystemDataSet3";
            this.employee_Mgt_SystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.employee_Mgt_SystemDataSet1;
            // 
            // employee_Mgt_SystemDataSet1
            // 
            this.employee_Mgt_SystemDataSet1.DataSetName = "Employee_Mgt_SystemDataSet1";
            this.employee_Mgt_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Purple;
            this.btn_Logout.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Logout.Location = new System.Drawing.Point(851, 9);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(119, 51);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Add_Employee
            // 
            this.btn_Add_Employee.BackColor = System.Drawing.Color.Maroon;
            this.btn_Add_Employee.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold);
            this.btn_Add_Employee.ForeColor = System.Drawing.Color.Khaki;
            this.btn_Add_Employee.Location = new System.Drawing.Point(308, 660);
            this.btn_Add_Employee.Name = "btn_Add_Employee";
            this.btn_Add_Employee.Size = new System.Drawing.Size(402, 51);
            this.btn_Add_Employee.TabIndex = 1;
            this.btn_Add_Employee.Text = "Add New Employee";
            this.btn_Add_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_Employee.Click += new System.EventHandler(this.btn_Add_Employee_Click);
            // 
            // employee_Mgt_SystemDataSet
            // 
            this.employee_Mgt_SystemDataSet.DataSetName = "Employee_Mgt_SystemDataSet";
            this.employee_Mgt_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeMgtSystemDataSetBindingSource
            // 
            this.employeeMgtSystemDataSetBindingSource.DataSource = this.employee_Mgt_SystemDataSet;
            this.employeeMgtSystemDataSetBindingSource.Position = 0;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
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
            this.lbl_UName.TabIndex = 10;
            this.lbl_UName.Text = "LoggedInUser";
            // 
            // employee_DetailsTableAdapter1
            // 
            this.employee_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.btn_Add_Employee);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dgv_Employee_List);
            this.Controls.Add(this.lbl_Employee_Details);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_View_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frm_View_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Mgt_SystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Mgt_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Mgt_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeMgtSystemDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details;
        private System.Windows.Forms.DataGridView dgv_Employee_List;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Add_Employee;
        private System.Windows.Forms.BindingSource employeeMgtSystemDataSetBindingSource;
        private Employee_Mgt_SystemDataSet employee_Mgt_SystemDataSet;
        private Employee_Mgt_SystemDataSet1 employee_Mgt_SystemDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_Mgt_SystemDataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_UName;
        private Employee_Mgt_SystemDataSet3 employee_Mgt_SystemDataSet3;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource1;
        private Employee_Mgt_SystemDataSet3TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter1;
    }
}