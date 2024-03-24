namespace Tesst01
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.buttonLoc01 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLoc02 = new System.Windows.Forms.Button();
            this.buttonLoc03 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ma SV :";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID.Location = new System.Drawing.Point(198, 40);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(237, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Noi Sinh:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ha Noi",
            "Hai Duong",
            "Thai Binh",
            "Quang Ninh",
            "Da Nang"});
            this.comboBox1.Location = new System.Drawing.Point(198, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gioi tinh:";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(296, 124);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(39, 17);
            this.radioButtonFemale.TabIndex = 12;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Nu";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(198, 124);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(47, 17);
            this.radioButtonMale.TabIndex = 11;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Nam";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonLoc01
            // 
            this.buttonLoc01.Location = new System.Drawing.Point(480, 40);
            this.buttonLoc01.Name = "buttonLoc01";
            this.buttonLoc01.Size = new System.Drawing.Size(75, 20);
            this.buttonLoc01.TabIndex = 14;
            this.buttonLoc01.Text = "Loc";
            this.buttonLoc01.UseVisualStyleBackColor = true;
            this.buttonLoc01.Click += new System.EventHandler(this.buttonLoc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 246);
            this.dataGridView1.TabIndex = 15;
            // 
            // buttonLoc02
            // 
            this.buttonLoc02.Location = new System.Drawing.Point(480, 80);
            this.buttonLoc02.Name = "buttonLoc02";
            this.buttonLoc02.Size = new System.Drawing.Size(75, 20);
            this.buttonLoc02.TabIndex = 16;
            this.buttonLoc02.Text = "Loc";
            this.buttonLoc02.UseVisualStyleBackColor = true;
            this.buttonLoc02.Click += new System.EventHandler(this.buttonLoc02_Click);
            // 
            // buttonLoc03
            // 
            this.buttonLoc03.Location = new System.Drawing.Point(480, 121);
            this.buttonLoc03.Name = "buttonLoc03";
            this.buttonLoc03.Size = new System.Drawing.Size(75, 20);
            this.buttonLoc03.TabIndex = 17;
            this.buttonLoc03.Text = "Loc";
            this.buttonLoc03.UseVisualStyleBackColor = true;
            this.buttonLoc03.Click += new System.EventHandler(this.buttonLoc03_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(705, 436);
            this.Controls.Add(this.buttonLoc03);
            this.Controls.Add(this.buttonLoc02);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLoc01);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button buttonLoc01;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonLoc02;
        private System.Windows.Forms.Button buttonLoc03;
    }
}