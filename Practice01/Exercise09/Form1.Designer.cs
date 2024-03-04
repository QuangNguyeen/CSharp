namespace Exercise09
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
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.grB_ClassA = new System.Windows.Forms.GroupBox();
            this.grB_ClassB = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBoxClassA = new System.Windows.Forms.ListBox();
            this.listBoxClassB = new System.Windows.Forms.ListBox();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grB_ClassA.SuspendLayout();
            this.grB_ClassB.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(481, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "DANH SACH SINH VIEN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(74, 82);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(197, 20);
            this.textName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(277, 83);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(163, 23);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // grB_ClassA
            // 
            this.grB_ClassA.Controls.Add(this.listBoxClassA);
            this.grB_ClassA.Location = new System.Drawing.Point(36, 143);
            this.grB_ClassA.Name = "grB_ClassA";
            this.grB_ClassA.Size = new System.Drawing.Size(170, 185);
            this.grB_ClassA.TabIndex = 4;
            this.grB_ClassA.TabStop = false;
            this.grB_ClassA.Text = "Class A";
            // 
            // grB_ClassB
            // 
            this.grB_ClassB.Controls.Add(this.listBoxClassB);
            this.grB_ClassB.Location = new System.Drawing.Point(277, 143);
            this.grB_ClassB.Name = "grB_ClassB";
            this.grB_ClassB.Size = new System.Drawing.Size(172, 185);
            this.grB_ClassB.TabIndex = 5;
            this.grB_ClassB.TabStop = false;
            this.grB_ClassB.Text = "Class B";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(212, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(212, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(212, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBoxClassA
            // 
            this.listBoxClassA.FormattingEnabled = true;
            this.listBoxClassA.Location = new System.Drawing.Point(6, 21);
            this.listBoxClassA.Name = "listBoxClassA";
            this.listBoxClassA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxClassA.Size = new System.Drawing.Size(158, 160);
            this.listBoxClassA.TabIndex = 0;
            // 
            // listBoxClassB
            // 
            this.listBoxClassB.FormattingEnabled = true;
            this.listBoxClassB.Location = new System.Drawing.Point(6, 19);
            this.listBoxClassB.Name = "listBoxClassB";
            this.listBoxClassB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxClassB.Size = new System.Drawing.Size(158, 160);
            this.listBoxClassB.TabIndex = 1;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(74, 342);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 10;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(331, 342);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Finish";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Class A",
            "Class B"});
            this.comboBox1.Location = new System.Drawing.Point(74, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Class";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grB_ClassB);
            this.Controls.Add(this.grB_ClassA);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.grB_ClassA.ResumeLayout(false);
            this.grB_ClassB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.GroupBox grB_ClassA;
        private System.Windows.Forms.GroupBox grB_ClassB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBoxClassA;
        private System.Windows.Forms.ListBox listBoxClassB;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

