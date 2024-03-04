namespace Exercise08
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
            this.button1 = new System.Windows.Forms.Button();
            this.grB_ListBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grB_HandleListBox = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.grB_ListBox.SuspendLayout();
            this.grB_HandleListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "LISTBOX";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grB_ListBox
            // 
            this.grB_ListBox.Controls.Add(this.listBox1);
            this.grB_ListBox.Controls.Add(this.btn_Enter);
            this.grB_ListBox.Controls.Add(this.textBox1);
            this.grB_ListBox.Location = new System.Drawing.Point(12, 54);
            this.grB_ListBox.Name = "grB_ListBox";
            this.grB_ListBox.Size = new System.Drawing.Size(134, 228);
            this.grB_ListBox.TabIndex = 1;
            this.grB_ListBox.TabStop = false;
            this.grB_ListBox.Text = "ListBox";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(122, 147);
            this.listBox1.TabIndex = 2;
            // 
            // btn_Enter
            // 
            this.btn_Enter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Enter.Location = new System.Drawing.Point(6, 48);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(122, 23);
            this.btn_Enter.TabIndex = 1;
            this.btn_Enter.Text = "Nhap";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            // 
            // grB_HandleListBox
            // 
            this.grB_HandleListBox.Controls.Add(this.button8);
            this.grB_HandleListBox.Controls.Add(this.button7);
            this.grB_HandleListBox.Controls.Add(this.button6);
            this.grB_HandleListBox.Controls.Add(this.button5);
            this.grB_HandleListBox.Controls.Add(this.button4);
            this.grB_HandleListBox.Controls.Add(this.button3);
            this.grB_HandleListBox.Controls.Add(this.button2);
            this.grB_HandleListBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grB_HandleListBox.Location = new System.Drawing.Point(152, 54);
            this.grB_HandleListBox.Name = "grB_HandleListBox";
            this.grB_HandleListBox.Size = new System.Drawing.Size(187, 228);
            this.grB_HandleListBox.TabIndex = 2;
            this.grB_HandleListBox.TabStop = false;
            this.grB_HandleListBox.Text = "Xu Ly ListBox";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 193);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Chon So Le";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 164);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "Chon So Chan";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Thay Bang Binh Phuong";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 106);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Tang Moi Phan Tu Len 2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Xoa Phan Tu Dang Chon";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Xoa Phan Tu Dau Va Cuoi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tong Phan Tu Trong List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(12, 288);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(327, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Thoat";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 325);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.grB_HandleListBox);
            this.Controls.Add(this.grB_ListBox);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Peru;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grB_ListBox.ResumeLayout(false);
            this.grB_ListBox.PerformLayout();
            this.grB_HandleListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grB_ListBox;
        private System.Windows.Forms.GroupBox grB_HandleListBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
    }
}

