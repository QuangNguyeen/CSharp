namespace TH08_De07
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxMaSach = new System.Windows.Forms.TextBox();
            this.textBoxTenSach = new System.Windows.Forms.TextBox();
            this.buttonThemSach = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSinhVien = new System.Windows.Forms.ComboBox();
            this.comboBoxSach = new System.Windows.Forms.ComboBox();
            this.dateTimePickerMuon = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTra = new System.Windows.Forms.DateTimePicker();
            this.buttonMuon = new System.Windows.Forms.Button();
            this.buttonTra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSoNgayMuon = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonThemSach);
            this.tabPage1.Controls.Add(this.textBoxTenSach);
            this.tabPage1.Controls.Add(this.textBoxMaSach);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quan ly sach";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.labelSoNgayMuon);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.buttonTra);
            this.tabPage2.Controls.Add(this.buttonMuon);
            this.tabPage2.Controls.Add(this.dateTimePickerTra);
            this.tabPage2.Controls.Add(this.dateTimePickerMuon);
            this.tabPage2.Controls.Add(this.comboBoxSach);
            this.tabPage2.Controls.Add(this.comboBoxSinhVien);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Muon/ Tra sach";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thong ke";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxMaSach
            // 
            this.textBoxMaSach.Location = new System.Drawing.Point(184, 41);
            this.textBoxMaSach.Name = "textBoxMaSach";
            this.textBoxMaSach.Size = new System.Drawing.Size(241, 20);
            this.textBoxMaSach.TabIndex = 0;
            // 
            // textBoxTenSach
            // 
            this.textBoxTenSach.Location = new System.Drawing.Point(184, 83);
            this.textBoxTenSach.Name = "textBoxTenSach";
            this.textBoxTenSach.Size = new System.Drawing.Size(241, 20);
            this.textBoxTenSach.TabIndex = 1;
            // 
            // buttonThemSach
            // 
            this.buttonThemSach.Location = new System.Drawing.Point(501, 41);
            this.buttonThemSach.Name = "buttonThemSach";
            this.buttonThemSach.Size = new System.Drawing.Size(103, 62);
            this.buttonThemSach.TabIndex = 2;
            this.buttonThemSach.Text = "Them sach";
            this.buttonThemSach.UseVisualStyleBackColor = true;
            this.buttonThemSach.Click += new System.EventHandler(this.buttonThemSach_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(768, 260);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ma sach:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ten sach:";
            // 
            // comboBoxSinhVien
            // 
            this.comboBoxSinhVien.FormattingEnabled = true;
            this.comboBoxSinhVien.Items.AddRange(new object[] {
            "Quang",
            "Nhi",
            "Quyen",
            "Trang",
            "Thuy",
            "Quoc Huy",
            "Quang Anh",
            "Viet Hung",
            "Manh",
            "Hien Hoa",
            "Mai Phuong"});
            this.comboBoxSinhVien.Location = new System.Drawing.Point(192, 38);
            this.comboBoxSinhVien.Name = "comboBoxSinhVien";
            this.comboBoxSinhVien.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSinhVien.TabIndex = 0;
            // 
            // comboBoxSach
            // 
            this.comboBoxSach.FormattingEnabled = true;
            this.comboBoxSach.Location = new System.Drawing.Point(192, 89);
            this.comboBoxSach.Name = "comboBoxSach";
            this.comboBoxSach.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSach.TabIndex = 1;
            // 
            // dateTimePickerMuon
            // 
            this.dateTimePickerMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMuon.Location = new System.Drawing.Point(447, 38);
            this.dateTimePickerMuon.Name = "dateTimePickerMuon";
            this.dateTimePickerMuon.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerMuon.TabIndex = 2;
            this.dateTimePickerMuon.ValueChanged += new System.EventHandler(this.dateTimePickerMuon_ValueChanged);
            // 
            // dateTimePickerTra
            // 
            this.dateTimePickerTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTra.Location = new System.Drawing.Point(447, 86);
            this.dateTimePickerTra.Name = "dateTimePickerTra";
            this.dateTimePickerTra.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerTra.TabIndex = 3;
            this.dateTimePickerTra.ValueChanged += new System.EventHandler(this.dateTimePickerTra_ValueChanged);
            // 
            // buttonMuon
            // 
            this.buttonMuon.Location = new System.Drawing.Point(596, 35);
            this.buttonMuon.Name = "buttonMuon";
            this.buttonMuon.Size = new System.Drawing.Size(75, 23);
            this.buttonMuon.TabIndex = 4;
            this.buttonMuon.Text = "Muon";
            this.buttonMuon.UseVisualStyleBackColor = true;
            this.buttonMuon.Click += new System.EventHandler(this.buttonMuon_Click);
            // 
            // buttonTra
            // 
            this.buttonTra.Location = new System.Drawing.Point(596, 84);
            this.buttonTra.Name = "buttonTra";
            this.buttonTra.Size = new System.Drawing.Size(75, 23);
            this.buttonTra.TabIndex = 5;
            this.buttonTra.Text = "Tra";
            this.buttonTra.UseVisualStyleBackColor = true;
            this.buttonTra.Click += new System.EventHandler(this.buttonTra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ten Sinh Vien:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ten Sach";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(786, 238);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngay muon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngay tra:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "So ngay muon:";
            // 
            // labelSoNgayMuon
            // 
            this.labelSoNgayMuon.AutoSize = true;
            this.labelSoNgayMuon.Location = new System.Drawing.Point(475, 136);
            this.labelSoNgayMuon.Name = "labelSoNgayMuon";
            this.labelSoNgayMuon.Size = new System.Drawing.Size(13, 13);
            this.labelSoNgayMuon.TabIndex = 12;
            this.labelSoNgayMuon.Text = "0";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(786, 418);
            this.dataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly muon sach - Nguyen Van Quang - 2251172466";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonThemSach;
        private System.Windows.Forms.TextBox textBoxTenSach;
        private System.Windows.Forms.TextBox textBoxMaSach;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTra;
        private System.Windows.Forms.Button buttonMuon;
        private System.Windows.Forms.DateTimePicker dateTimePickerTra;
        private System.Windows.Forms.DateTimePicker dateTimePickerMuon;
        private System.Windows.Forms.ComboBox comboBoxSach;
        private System.Windows.Forms.ComboBox comboBoxSinhVien;
        private System.Windows.Forms.Label labelSoNgayMuon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

