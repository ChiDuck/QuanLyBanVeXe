namespace WindowsFormsApp1.KiemSoatUser
{
    partial class UserDatVe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSoVe = new System.Windows.Forms.Label();
            this.txtDiemDi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSoVe = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemDen = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGheNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimXe = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Vé ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblSoVe
            // 
            this.lblSoVe.AutoSize = true;
            this.lblSoVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoVe.Location = new System.Drawing.Point(674, 14);
            this.lblSoVe.Name = "lblSoVe";
            this.lblSoVe.Size = new System.Drawing.Size(65, 18);
            this.lblSoVe.TabIndex = 2;
            this.lblSoVe.Text = "Điểm đi";
            // 
            // txtDiemDi
            // 
            this.txtDiemDi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemDi.DefaultText = "";
            this.txtDiemDi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiemDi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiemDi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemDi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemDi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemDi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDi.ForeColor = System.Drawing.Color.Black;
            this.txtDiemDi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemDi.Location = new System.Drawing.Point(675, 34);
            this.txtDiemDi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiemDi.Name = "txtDiemDi";
            this.txtDiemDi.PasswordChar = '\0';
            this.txtDiemDi.PlaceholderText = "";
            this.txtDiemDi.SelectedText = "";
            this.txtDiemDi.Size = new System.Drawing.Size(237, 36);
            this.txtDiemDi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(677, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số vé ";
            // 
            // cbSoVe
            // 
            this.cbSoVe.BackColor = System.Drawing.Color.Transparent;
            this.cbSoVe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSoVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoVe.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoVe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSoVe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoVe.ForeColor = System.Drawing.Color.Black;
            this.cbSoVe.ItemHeight = 30;
            this.cbSoVe.Location = new System.Drawing.Point(677, 119);
            this.cbSoVe.Name = "cbSoVe";
            this.cbSoVe.Size = new System.Drawing.Size(162, 36);
            this.cbSoVe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(953, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điểm đến";
            // 
            // txtDiemDen
            // 
            this.txtDiemDen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemDen.DefaultText = "";
            this.txtDiemDen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiemDen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiemDen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemDen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemDen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemDen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemDen.ForeColor = System.Drawing.Color.Black;
            this.txtDiemDen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemDen.Location = new System.Drawing.Point(961, 34);
            this.txtDiemDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiemDen.Name = "txtDiemDen";
            this.txtDiemDen.PasswordChar = '\0';
            this.txtDiemDen.PlaceholderText = "";
            this.txtDiemDen.SelectedText = "";
            this.txtDiemDen.Size = new System.Drawing.Size(237, 36);
            this.txtDiemDen.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(680, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày Đi";
            // 
            // cbGheNam
            // 
            this.cbGheNam.BackColor = System.Drawing.Color.Transparent;
            this.cbGheNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGheNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGheNam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGheNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGheNam.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGheNam.ForeColor = System.Drawing.Color.Black;
            this.cbGheNam.ItemHeight = 30;
            this.cbGheNam.Location = new System.Drawing.Point(965, 116);
            this.cbGheNam.Name = "cbGheNam";
            this.cbGheNam.Size = new System.Drawing.Size(162, 36);
            this.cbGheNam.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(961, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số ghế nằm";
            // 
            // btnTimXe
            // 
            this.btnTimXe.BackColor = System.Drawing.Color.White;
            this.btnTimXe.BorderColor = System.Drawing.Color.White;
            this.btnTimXe.BorderRadius = 18;
            this.btnTimXe.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnTimXe.BorderThickness = 1;
            this.btnTimXe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimXe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimXe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimXe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimXe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTimXe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimXe.ForeColor = System.Drawing.Color.White;
            this.btnTimXe.Location = new System.Drawing.Point(771, 282);
            this.btnTimXe.Name = "btnTimXe";
            this.btnTimXe.Size = new System.Drawing.Size(180, 45);
            this.btnTimXe.TabIndex = 12;
            this.btnTimXe.Text = "Tìm chuyến xe";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Aqua;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(677, 213);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(295, 36);
            this.guna2DateTimePicker1.TabIndex = 13;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 4, 1, 21, 53, 1, 386);
            // 
            // UserDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.btnTimXe);
            this.Controls.Add(this.cbGheNam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiemDen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSoVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiemDi);
            this.Controls.Add(this.lblSoVe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UserDatVe";
            this.Size = new System.Drawing.Size(1370, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSoVe;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemDi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbSoVe;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDiemDen;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbGheNam;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnTimXe;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}
