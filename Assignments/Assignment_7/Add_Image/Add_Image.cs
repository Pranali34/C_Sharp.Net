using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Image
{
    public partial class Add_Image : Form
    {
        public Add_Image()
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
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Img_Id.Clear();
            tb_Img_Discription.Clear();
            pb_Add_Img.Image = null;

        }
        private void Add_Image_Load(object sender, EventArgs e)
        {
            tb_Img_Id.Focus();
        }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Image Files(*.jpg;*.jpeg;*.gip;*.bmp)|*.jpg;*.jpeg;*.gip;*.bmp";

            if(OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Add_Img.Image = new Bitmap(OFD.FileName);
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Img_Id.Text != "" && tb_Img_Discription.Text != "" && pb_Add_Img.Text != null)
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Nature_Images Values(@Id,@Img_Details,@Image)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Img_Id.Text;
                Cmd.Parameters.Add("Img_Details", SqlDbType.NVarChar).Value = tb_Img_Discription.Text;

                ImageConverter IC = new ImageConverter();

                byte[] ImgArray = (byte[])IC.ConvertTo(pb_Add_Img.Image, typeof(byte[]));

                Cmd.Parameters.Add("@Image", SqlDbType.Image).Value = ImgArray;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_Show_Img_Click(object sender, EventArgs e)
        {
            Show_Image Obj = new Show_Image();
            Obj.Show();
            this.Hide();
        }
    }
}
