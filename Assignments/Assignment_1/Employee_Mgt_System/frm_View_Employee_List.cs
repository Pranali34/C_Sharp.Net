﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Mgt_System
{
    public partial class frm_view_Employee_List : Form
    {
        public frm_view_Employee_List()
        {
            InitializeComponent();
        }

        private void frm_view_Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'p_One_Employee_Mgt_SystemDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.p_One_Employee_Mgt_SystemDataSet.Employee_Details);
        }

        private void btn_Add_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee obj = new frm_Add_New_Employee();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

    }
}
