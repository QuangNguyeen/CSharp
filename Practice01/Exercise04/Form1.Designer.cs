namespace Exercise04
{
    partial class frmFormater
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtn_Black = new System.Windows.Forms.RadioButton();
            this.rBtn_Blue = new System.Windows.Forms.RadioButton();
            this.rBtn_Green = new System.Windows.Forms.RadioButton();
            this.rBtn_Red = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cB_Underline = new System.Windows.Forms.CheckBox();
            this.cB_Italic = new System.Windows.Forms.CheckBox();
            this.cB_Bold = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.lb_Result = new System.Windows.Forms.Label();
            this.lbresult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtn_Black);
            this.groupBox1.Controls.Add(this.rBtn_Blue);
            this.groupBox1.Controls.Add(this.rBtn_Green);
            this.groupBox1.Controls.Add(this.rBtn_Red);
            this.groupBox1.Location = new System.Drawing.Point(37, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // rBtn_Black
            // 
            this.rBtn_Black.AutoSize = true;
            this.rBtn_Black.Location = new System.Drawing.Point(16, 88);
            this.rBtn_Black.Name = "rBtn_Black";
            this.rBtn_Black.Size = new System.Drawing.Size(52, 17);
            this.rBtn_Black.TabIndex = 3;
            this.rBtn_Black.TabStop = true;
            this.rBtn_Black.Text = "Black";
            this.rBtn_Black.UseVisualStyleBackColor = true;
            this.rBtn_Black.CheckedChanged += new System.EventHandler(this.rBtn_Black_CheckedChanged);
            // 
            // rBtn_Blue
            // 
            this.rBtn_Blue.AutoSize = true;
            this.rBtn_Blue.ForeColor = System.Drawing.Color.Blue;
            this.rBtn_Blue.Location = new System.Drawing.Point(16, 65);
            this.rBtn_Blue.Name = "rBtn_Blue";
            this.rBtn_Blue.Size = new System.Drawing.Size(46, 17);
            this.rBtn_Blue.TabIndex = 2;
            this.rBtn_Blue.TabStop = true;
            this.rBtn_Blue.Text = "Blue";
            this.rBtn_Blue.UseVisualStyleBackColor = true;
            this.rBtn_Blue.CheckedChanged += new System.EventHandler(this.rBtn_Blue_CheckedChanged);
            // 
            // rBtn_Green
            // 
            this.rBtn_Green.AutoSize = true;
            this.rBtn_Green.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rBtn_Green.Location = new System.Drawing.Point(16, 42);
            this.rBtn_Green.Name = "rBtn_Green";
            this.rBtn_Green.Size = new System.Drawing.Size(54, 17);
            this.rBtn_Green.TabIndex = 1;
            this.rBtn_Green.TabStop = true;
            this.rBtn_Green.Text = "Green";
            this.rBtn_Green.UseVisualStyleBackColor = true;
            this.rBtn_Green.CheckedChanged += new System.EventHandler(this.rBtn_Green_CheckedChanged);
            // 
            // rBtn_Red
            // 
            this.rBtn_Red.AutoSize = true;
            this.rBtn_Red.ForeColor = System.Drawing.Color.Red;
            this.rBtn_Red.Location = new System.Drawing.Point(16, 19);
            this.rBtn_Red.Name = "rBtn_Red";
            this.rBtn_Red.Size = new System.Drawing.Size(45, 17);
            this.rBtn_Red.TabIndex = 0;
            this.rBtn_Red.TabStop = true;
            this.rBtn_Red.Text = "Red";
            this.rBtn_Red.UseVisualStyleBackColor = true;
            this.rBtn_Red.CheckedChanged += new System.EventHandler(this.rBtn_Red_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cB_Underline);
            this.groupBox2.Controls.Add(this.cB_Italic);
            this.groupBox2.Controls.Add(this.cB_Bold);
            this.groupBox2.Location = new System.Drawing.Point(161, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font";
            // 
            // cB_Underline
            // 
            this.cB_Underline.AutoSize = true;
            this.cB_Underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Underline.Location = new System.Drawing.Point(17, 65);
            this.cB_Underline.Name = "cB_Underline";
            this.cB_Underline.Size = new System.Drawing.Size(71, 17);
            this.cB_Underline.TabIndex = 2;
            this.cB_Underline.Text = "Underline";
            this.cB_Underline.UseVisualStyleBackColor = true;
            this.cB_Underline.CheckedChanged += new System.EventHandler(this.cB_Underline_CheckedChanged);
            // 
            // cB_Italic
            // 
            this.cB_Italic.AutoSize = true;
            this.cB_Italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Italic.Location = new System.Drawing.Point(17, 42);
            this.cB_Italic.Name = "cB_Italic";
            this.cB_Italic.Size = new System.Drawing.Size(48, 17);
            this.cB_Italic.TabIndex = 1;
            this.cB_Italic.Text = "Italic";
            this.cB_Italic.UseVisualStyleBackColor = true;
            this.cB_Italic.CheckedChanged += new System.EventHandler(this.cB_Italic_CheckedChanged);
            // 
            // cB_Bold
            // 
            this.cB_Bold.AutoSize = true;
            this.cB_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Bold.Location = new System.Drawing.Point(17, 19);
            this.cB_Bold.Name = "cB_Bold";
            this.cB_Bold.Size = new System.Drawing.Size(51, 17);
            this.cB_Bold.TabIndex = 0;
            this.cB_Bold.Text = "Bold";
            this.cB_Bold.UseVisualStyleBackColor = true;
            this.cB_Bold.CheckedChanged += new System.EventHandler(this.cB_Bold_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(34, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Create by: ";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(178, 323);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 34);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(101, 44);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(152, 20);
            this.textName.TabIndex = 7;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Result.Location = new System.Drawing.Point(99, 272);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(0, 13);
            this.lb_Result.TabIndex = 8;
            this.lb_Result.Click += new System.EventHandler(this.lb_Result_Click);
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(98, 272);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(32, 13);
            this.lbresult.TabIndex = 9;
            this.lbresult.Text = "result";
            // 
            // frmFormater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 395);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmFormater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFormater_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cB_Italic;
        private System.Windows.Forms.CheckBox cB_Bold;
        private System.Windows.Forms.RadioButton rBtn_Black;
        private System.Windows.Forms.RadioButton rBtn_Blue;
        private System.Windows.Forms.RadioButton rBtn_Green;
        private System.Windows.Forms.RadioButton rBtn_Red;
        private System.Windows.Forms.CheckBox cB_Underline;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Label lbresult;
    }
}

