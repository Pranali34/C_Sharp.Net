using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Image
{
    public partial class Show_Image : Form
    {
        public Show_Image()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-CHE5P3L\SQLEXPRESS;Initial Catalog=Nature_Images_List;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void Show_Image_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select Id, Image_Details From Nature_Images", dgv_Img_List);
        }
        void Bind_Grid(String Query, DataGridView Obj)
        {
            Con_Open();

            Obj.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            Obj.DataSource = dt;

            Con_Close();
        }
        void View_Image(String Query, PictureBox pb)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand(Query, Con);

            SqlDataAdapter da = new SqlDataAdapter(Cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            if(ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pb.Image = new Bitmap(ms);
            }
            else
            {
                MessageBox.Show("Invalid Image ID !!!");
            }

            Con_Close();
        }
        private void dgv_Img_List_SelectionChanged(object sender, EventArgs e)
        {
            int SelectedRowCount = dgv_Img_List.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(SelectedRowCount == 1)
            {
                string value = dgv_Img_List.SelectedCells[0].RowIndex.ToString();

                int Index = Convert.ToInt32(value);

                int ID = Convert.ToInt32(dgv_Img_List.Rows[Index].Cells[0].Value);

                View_Image("Select Image From Nature_Images where Id = " + ID + "", pb_Show_Img);
            }
        }

        private void btn_Add_Img_Click(object sender, EventArgs e)
        {
            Add_Image Obj = new Add_Image();
            Obj.Show();
            this.Hide();
        }
    }
}
