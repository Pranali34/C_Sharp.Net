
namespace Add_Image
{
    partial class Show_Image
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
            this.lbl_Image_List = new System.Windows.Forms.Label();
            this.lbl_Show_Image = new System.Windows.Forms.Label();
            this.dgv_Img_List = new System.Windows.Forms.DataGridView();
            this.lbl_Show_Img = new System.Windows.Forms.Label();
            this.btn_Add_Img = new System.Windows.Forms.Button();
            this.pb_Show_Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Img_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Show_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Image_List
            // 
            this.lbl_Image_List.AutoSize = true;
            this.lbl_Image_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Image_List.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Image_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Image_List.Location = new System.Drawing.Point(773, 135);
            this.lbl_Image_List.Name = "lbl_Image_List";
            this.lbl_Image_List.Size = new System.Drawing.Size(133, 30);
            this.lbl_Image_List.TabIndex = 5;
            this.lbl_Image_List.Text = "Image List";
            // 
            // lbl_Show_Image
            // 
            this.lbl_Show_Image.AutoSize = true;
            this.lbl_Show_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Show_Image.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Show_Image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Show_Image.Location = new System.Drawing.Point(189, 135);
            this.lbl_Show_Image.Name = "lbl_Show_Image";
            this.lbl_Show_Image.Size = new System.Drawing.Size(153, 30);
            this.lbl_Show_Image.TabIndex = 6;
            this.lbl_Show_Image.Text = "Show Image";
            // 
            // dgv_Img_List
            // 
            this.dgv_Img_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Img_List.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgv_Img_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Img_List.Location = new System.Drawing.Point(607, 181);
            this.dgv_Img_List.Name = "dgv_Img_List";
            this.dgv_Img_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgv_Img_List.RowTemplate.Height = 24;
            this.dgv_Img_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Img_List.Size = new System.Drawing.Size(464, 384);
            this.dgv_Img_List.TabIndex = 8;
            this.dgv_Img_List.SelectionChanged += new System.EventHandler(this.dgv_Img_List_SelectionChanged);
            // 
            // lbl_Show_Img
            // 
            this.lbl_Show_Img.AutoSize = true;
            this.lbl_Show_Img.BackColor = System.Drawing.Color.Maroon;
            this.lbl_Show_Img.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Show_Img.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_Show_Img.Location = new System.Drawing.Point(423, 31);
            this.lbl_Show_Img.Name = "lbl_Show_Img";
            this.lbl_Show_Img.Size = new System.Drawing.Size(273, 50);
            this.lbl_Show_Img.TabIndex = 10;
            this.lbl_Show_Img.Text = "Insert Image";
            // 
            // btn_Add_Img
            // 
            this.btn_Add_Img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Add_Img.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Img.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Add_Img.Location = new System.Drawing.Point(447, 620);
            this.btn_Add_Img.Name = "btn_Add_Img";
            this.btn_Add_Img.Size = new System.Drawing.Size(200, 49);
            this.btn_Add_Img.TabIndex = 1;
            this.btn_Add_Img.Text = "Add Images";
            this.btn_Add_Img.UseVisualStyleBackColor = false;
            this.btn_Add_Img.Click += new System.EventHandler(this.btn_Add_Img_Click);
            // 
            // pb_Show_Img
            // 
            this.pb_Show_Img.BackColor = System.Drawing.Color.White;
            this.pb_Show_Img.Location = new System.Drawing.Point(41, 181);
            this.pb_Show_Img.Name = "pb_Show_Img";
            this.pb_Show_Img.Size = new System.Drawing.Size(459, 384);
            this.pb_Show_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Show_Img.TabIndex = 11;
            this.pb_Show_Img.TabStop = false;
            // 
            // Show_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1122, 703);
            this.Controls.Add(this.pb_Show_Img);
            this.Controls.Add(this.btn_Add_Img);
            this.Controls.Add(this.lbl_Show_Img);
            this.Controls.Add(this.dgv_Img_List);
            this.Controls.Add(this.lbl_Show_Image);
            this.Controls.Add(this.lbl_Image_List);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Show_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Image";
            this.Load += new System.EventHandler(this.Show_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Img_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Show_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Image_List;
        private System.Windows.Forms.Label lbl_Show_Image;
        private System.Windows.Forms.DataGridView dgv_Img_List;
        private System.Windows.Forms.Label lbl_Show_Img;
        private System.Windows.Forms.Button btn_Add_Img;
        private System.Windows.Forms.PictureBox pb_Show_Img;
    }
}